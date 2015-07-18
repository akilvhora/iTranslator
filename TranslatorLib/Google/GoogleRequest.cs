using System.IO;
using System.Net;
using TranslatorLib.Google.Exceptions;

namespace TranslatorLib.Google
{
    public class GoogleRequest : IGoogleRequest
    {
        public string Execute(string requestUri)
        {
            var request = WebRequest.Create(requestUri);
            request.ContentType = "application/json; charset=utf-8";
            var response = (HttpWebResponse)request.GetResponse();

            if (response.GetResponseStream() == null)
            {
                throw new NoContentFoundException("No Content Found");
            }

            string text;
            // ReSharper disable AssignNullToNotNullAttribute
            using (var sr = new StreamReader(stream: response.GetResponseStream()))
            // ReSharper restore AssignNullToNotNullAttribute
            {
                text = sr.ReadToEnd();
            }

            return text;
        }
    }
}
