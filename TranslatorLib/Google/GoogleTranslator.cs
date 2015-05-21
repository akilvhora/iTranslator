using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using Newtonsoft.Json;
using System.Configuration;

namespace TranslatorLib.Google
{
    public class GoogleTranslator : ITranslate
    {
        private readonly string _baseUrl = ConfigurationManager.AppSettings["GoogleBaseUrl"];
        private readonly string _key = ConfigurationManager.AppSettings["GoogleApiKey"];

        public List<string> Translate(string input, string fromLangauge, string toLangauge)
        {
            var responseText = Execute(input, fromLangauge, toLangauge);
            var data = JsonConvert.DeserializeObject<GoogleTranslation>(responseText);

            return data.Data.Translations.Select(translation => translation.TranslatedText).ToList();
        }

        private string Execute(string input, string fromLangauge, string toLangauge)
        {
            var shortFromLangauge = Langauge.GetInstanse().GetLanguageShortName(fromLangauge);
            var shortToLangauge = Langauge.GetInstanse().GetLanguageShortName(toLangauge);

            if (shortFromLangauge == null || shortToLangauge == null)
                throw new Exception("Invalid Langauge Name");

            var requestUri = string.Format("{0}key={1}&source={2}&target={3}&q={4}", _baseUrl, _key, shortFromLangauge,
                shortToLangauge, input);

            var request = WebRequest.Create(requestUri);
            request.ContentType = "application/json; charset=utf-8";
            var response = (HttpWebResponse)request.GetResponse();

            if (response.GetResponseStream() == null)
                throw new Exception("No Content Found");

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
