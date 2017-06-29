namespace app.utils.Providers
{
    public sealed class RemoteResponseProvider : IResponseProvider
    {
        private string _body;

        public string GetBody()
        {
            return _body;
        }

        public void SetBody(string rawString)
        {
            _body = rawString;
        }
        
    }
}