using System.Threading.Tasks;

namespace app.utils.Providers
{
    public interface IResponseProvider
    {
        bool HasValue{get;}
        Task<string> GetBodyAsync(string remoteUrl);
        void SetBody(string rawString);

    }
}