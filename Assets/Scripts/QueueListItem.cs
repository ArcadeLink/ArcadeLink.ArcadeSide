using System.Threading.Tasks;
using Managers;
using Models;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class QueueListItem : MonoBehaviour
{
    [SerializeField]
    private TMP_Text Username_Text, QueueId_Text;
    
    [SerializeField]
    private Image BackgroundImage;
    
    public async Task SetQueueItem(QueueItem item)
    {
        Username_Text.text = item.nickname;
        QueueId_Text.text = item.queueId.ToString();
        BackgroundImage.sprite = await CachedImageManager.Instance.GetImage(item.cardUrl);
        // TODO: LOAD IMAGE
    }
    
    public int QueueId => int.Parse(QueueId_Text.text);
}