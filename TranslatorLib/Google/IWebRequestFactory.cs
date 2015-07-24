using System.Net;

namespace TranslatorLib.Google
{
    public interface IWebRequestFactory
    {
        WebRequest Create(string uri);
    }
}
