namespace System.Net.Browser
{
    internal class ClientHttpWebRequestCreator : IWebRequestCreate
    {
        public WebRequest Create(Uri uri)
        {
            return WebRequest.CreateHttp(uri);
        }
    }
}