using System.Collections.Generic;
using System.Configuration;
using System.Linq;

using Newtonsoft.Json;

namespace TranslatorLib.Google
{
    using TranslatorLib.Google.Domain;
    using TranslatorLib.Google.Exceptions;

    public class GoogleTranslator : ITranslate
    {
        private readonly string _baseUrl = ConfigurationManager.AppSettings["GoogleBaseUrl"];
        private readonly string _key = ConfigurationManager.AppSettings["GoogleApiKey"];

        private IGoogleRequest googleRequest;

        public GoogleTranslator(IGoogleRequest googleRequest)
        {
            this.googleRequest = googleRequest;
        }

        public List<string> Translate(string input, string fromLangauge, string toLangauge)
        {
            var responseText = this.Execute(input, fromLangauge, toLangauge);
            var data = JsonConvert.DeserializeObject<Response>(responseText);

            return data.Data.Translations.Select(translation => translation.TranslatedText).ToList();
        }

        private string Execute(string input, string fromLangauge, string toLangauge)
        {
            var shortFromLangauge = this.GetShortLanguageName(fromLangauge);
            var shortToLangauge = this.GetShortLanguageName(toLangauge);

            if (shortFromLangauge == null || shortToLangauge == null)
            {
                throw new NoLanguageSupportException("Invalid Langauge Name");
            }

            var requestUri = this.GetUri(input, shortFromLangauge, shortToLangauge);

            return this.googleRequest.Execute(requestUri);
        }

        private string GetShortLanguageName(string languageName)
        {
            return Langauge.GetInstanse().GetLanguageShortName(languageName);
        }

        private string GetUri(string input, string shortFromLangauge, string shortToLangauge)
        {
            return string.Format(
                "{0}key={1}&source={2}&target={3}&q={4}",
                this._baseUrl,
                this._key,
                shortFromLangauge,
                shortToLangauge,
                input);
        }
    }
}
