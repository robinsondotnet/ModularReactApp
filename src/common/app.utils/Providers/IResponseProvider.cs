namespace app.utils.Providers
{
    public interface IResponseProvider
    {
        string GetBody();
        
        void SetBody(string rawString);

    }
}