using System;
using System.Threading.Tasks;
using Interfaces;
using Managers;
using Models;
using Newtonsoft.Json;
using Qiniu.Common;
using Qiniu.IO;
using Qiniu.IO.Model;
using Qiniu.RS;
using Qiniu.Util;
using RestEase;
using UnityEngine;

public class UploadService
{
    private static string QiniuAk;
    private static string QiniuSk;
    private static string FileUrl;
    private static string BucketName;
    private static int Qth;
    
    
    private static void ReadConfig()
    {
        // 读取配置文件
        var config = SettingsManager.Instance.Settings;
        QiniuAk = config.QiniuAk;
        QiniuSk = config.QiniuSk;
        FileUrl = config.FileUrl;
        BucketName = config.BucketName;
        Qth = config.LocationId;
        Debug.Log($"Config file loaded: Ak:{QiniuAk} Sk:{QiniuSk} FileUrl:{FileUrl} BucketName:{BucketName} Qth:{Qth}");
    }

    public static async Task Upload(string path, string userId)
    {
        ReadConfig();

        var mac = new Mac(QiniuAk, QiniuSk);
        var auth = new Auth(mac);

        await Config.AutoZoneAsync(
            QiniuAk,
            BucketName,
            true);

        await Console.Out.WriteLineAsync("Qiniu initialized");

        // 生成随机文件名字
        var name = Guid.NewGuid().ToString();

        // 上传策略，参见 
        // https://developer.qiniu.com/kodo/manual/put-policy
        var putPolicy = new PutPolicy()
        {
            Scope = $"{BucketName}:{name}",
            DeleteAfterDays = 1,
        };

        // 上传策略有效期(对应于生成的凭证的有效期)          
        putPolicy.SetExpires(3600);

        var putPolicyString = putPolicy.ToJsonString();
        var token = Auth.CreateUploadToken(mac, putPolicyString);
        var uploadManager = new UploadManager();
        var result = await uploadManager.UploadFileAsync(path, name, token);

        // 重命名加入后缀
        var bucketManager = new BucketManager(mac);
        var renameOp = await bucketManager.RenameAsync(BucketName, $"{name}", $"{name}.mkv");

        Debug.Log("Upload Finished.. Adding to database");

        // 上传到数据库
        var secret = SettingsManager.Instance.Settings.LocationKey;
        var api = new RestClient(SettingsManager.Instance.Settings.ApiEndpoint).For<IArcadeLinkApi>();
        var insertResult = await api.PostVideo(new HttpRequestModels.VideoInsertRequest()
        {
            userId = userId,
            locationId = Qth,
            url = Base64.UrlSafeBase64Encode($"{FileUrl}/{name}.mkv"),
            expiryTime = DateTime.Now.AddHours(1)
        }, secret);
        Debug.Log(JsonConvert.SerializeObject(insertResult));

        // 删除本地文件
    }

}