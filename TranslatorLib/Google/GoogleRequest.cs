﻿using System.IO;
using System.Net;

using TranslatorLib.Google.Exceptions;

namespace TranslatorLib.Google
{
    public class GoogleRequest : IGoogleRequest
    {
        private readonly IWebRequestFactory _webRequestFactory;

        public GoogleRequest(IWebRequestFactory factory)
        {
            _webRequestFactory = factory;
        }

        public string Execute(string requestUri)
        {
            var request = _webRequestFactory.Create(requestUri);
            request.ContentType = "application/json; charset=utf-8";
            var response = (HttpWebResponse)request.GetResponse();

            if (response.GetResponseStream() == null)
            {
                throw new NoContentFoundException("No Content Found");
            }
            
            var responseStream = response.GetResponseStream();

            return ReadStream(responseStream);
        }

        private string ReadStream(Stream stream)
        {
            string text;

            using (var sr = new StreamReader(stream))
            {
                text = sr.ReadToEnd();
            }

            return text;
        }
    }
}
