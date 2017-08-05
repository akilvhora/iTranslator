using System.Collections.Generic;
using System.Configuration;
using System.Linq;

using Newtonsoft.Json;
using TranslatorLib.Google.Domain;
using TranslatorLib.Google.Exceptions;

namespace TranslatorLib.Google
{
    public class GoogleTranslator : ITranslate
    {
        private readonly string _baseUrl = ConfigurationManager.AppSettings["GoogleBaseUrl"];
        private readonly string _key = ConfigurationManager.AppSettings["GoogleApiKey"];

        private readonly IGoogleRequest _googleRequest;

        public GoogleTranslator(IGoogleRequest googleRequest)
        {
            _googleRequest = googleRequest;
        }

        public List<string> Translate(string input, string fromLangauge, string toLangauge)
        {
            var responseText = Execute(input, fromLangauge, toLangauge);
            var data = JsonConvert.DeserializeObject<Response>(responseText);

            return data.Data.Translations.Select(translation => translation.TranslatedText).ToList();
        }

        private string Execute(string input, string fromLangauge, string toLangauge)
        {
            var shortFromLangauge = GetShortLanguageName(fromLangauge);
            var shortToLangauge = GetShortLanguageName(toLangauge);
            var requestUri = GetUri(input, shortFromLangauge, shortToLangauge);

            return _googleRequest.Execute(requestUri);
        }

        private string GetShortLanguageName(string languageName)
        {
            string languageShortName = Langauge.GetInstanse().GetLanguageShortName(languageName);

            if (string.IsNullOrEmpty(languageShortName))
            {
                throw new NoLanguageSupportException("Invalid Language Name");
            }

            return languageShortName;
        }

        private string GetUri(string input, string shortFromLangauge, string shortToLangauge)
        {
            return string.Format(
                "{0}key={1}&source={2}&target={3}&q={4}",
                _baseUrl,
                _key,
                shortFromLangauge,
                shortToLangauge,
                input);
        }
    }
}
