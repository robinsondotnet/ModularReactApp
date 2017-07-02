namespace app.utils.Providers
{
    public interface IResponseProvider
    {
        bool HasValue{get;}
        string GetBody();
        
        void SetBody(string rawString);

    }
}