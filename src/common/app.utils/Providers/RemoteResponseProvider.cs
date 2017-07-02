using System.Net.Http;
using System.Threading.Tasks;

namespace app.utils.Providers
{
    public sealed class RemoteResponseProvider : IResponseProvider
    {
        private string _body;

        public bool HasValue => !string.IsNullOrEmpty(_body);

        public async Task<string> GetBodyAsync(string remoteUrl = null)
        {
            if (string.IsNullOrEmpty(remoteUrl))
            {
                var tenant = new HttpClient();
                return await tenant.GetStringAsync(remoteUrl);
            }
            return _body;
        }

        public void SetBody(string rawString)
        {
            _body = rawString;
        }
        
    }
}