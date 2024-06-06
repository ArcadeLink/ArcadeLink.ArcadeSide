using System.Threading.Tasks;
using Models;
using RestEase;

namespace Interfaces
{
    public interface IArcadeLinkApi
    {
        [Get("/announcements")]
        Task<HttpApiResponse> GetAnnouncements();
    
        [Get("/users/pref/ar")]
        Task<HttpApiResponse> GetUserSecret([Query] string userId, [Query] int locationId, [Header("Secret")] string secret);

        [Get("/getRandomSayings")]
        Task<HttpApiResponse> GetRandomSayings();

        [Get("/queue")]
        Task<HttpApiResponse> GetQueue([Query] int locationId, [Query] int deviceId);

        [Post("/queue")]
        [Header("Secret")]
        Task<HttpApiResponse> PostQueue([Body] HttpRequestModels.QueueInsertRequest request, [Header("Secret")] string secret);
    
        [Delete("/queue")]
        [Header("Secret")]
        Task<HttpApiResponse> PassQueue([Body] HttpRequestModels.QueueDeleteRequest request, [Header("Secret")] string secret);
    
        [Post("/video")]
        [Header("Secret")]
        Task<HttpApiResponse> PostVideo([Body] HttpRequestModels.VideoInsertRequest request, [Header("Secret")] string secret);
        
        [Get("/location/{locationId}")]
        Task<HttpApiResponse> GetLocation([Path] int locationId);
    }
}