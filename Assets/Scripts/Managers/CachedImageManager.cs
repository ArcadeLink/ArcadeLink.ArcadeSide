using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;

namespace Managers
{
    public class CachedImageManager : MonoBehaviour 
    {
        public static CachedImageManager Instance { get; private set; }
        
        [SerializeField]
        private Sprite defaultSprite;

        private void Awake()
        {
            Instance = this;
        }
        
        public async Task<Sprite> GetImage(string url)
        {
            if (string.IsNullOrEmpty(url))
            {
                return defaultSprite;
            }
            
            url = url;
            
            // 用 md5 hash 检查图片是否已缓存
            var hash = url.Md5Hash();
            var path = $"{Application.persistentDataPath}/cached/{hash}.png";

            Debug.Log($"Checking cache for {url} at {path}");
            
            if (System.IO.File.Exists(path))
            {
                var bytes = await System.IO.File.ReadAllBytesAsync(path);
                var texture = new Texture2D(2, 2);
                texture.LoadImage(bytes);
                return Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f));
            }
            
            
            // 图片未缓存，下载图片
            UnityWebRequest uwr = UnityWebRequestTexture.GetTexture(url);
            await uwr.SendWebRequest();

            if (uwr.result != UnityWebRequest.Result.Success)
            {
                Debug.Log(uwr.error);
                return null;
            }
            else
            {
                // 下载完成，创建 sprite
                var texture = DownloadHandlerTexture.GetContent(uwr);
                var sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f));

                // 缓存图片
                byte[] bytes = texture.EncodeToPNG();
                System.IO.Directory.CreateDirectory($"{Application.persistentDataPath}/cached");
                await System.IO.File.WriteAllBytesAsync(path, bytes);

                return sprite;
            }
        }
        
    }
}