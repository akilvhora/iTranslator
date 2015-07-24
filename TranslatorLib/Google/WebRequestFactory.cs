using System.Net;

namespace TranslatorLib.Google
{
    public class WebRequestFactory : IWebRequestFactory
    {
        public WebRequest Create(string uri)
        {
            return WebRequest.Create(uri);
        }
    }
}
