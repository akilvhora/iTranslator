
using System.Collections.Generic;

namespace TranslatorLib.Google
{
    public class Langauge
    {
        private static Langauge _langauge;
        private static readonly Dictionary<string, string> Langauges = new Dictionary<string, string>();

        private Langauge()
        {
            Initialise();
        }

        private void Initialise()
        {
            Langauges.Add("Afrikaans", "af");
            Langauges.Add("Albanian", "sq");
            Langauges.Add("Arabic", "ar");
            Langauges.Add("Azerbaijani", "az");
            Langauges.Add("Basque", "eu");
            Langauges.Add("Bengali", "bn");
            Langauges.Add("Belarusian", "be");
            Langauges.Add("Bulgarian", "bg");
            Langauges.Add("Catalan", "ca");
            Langauges.Add("Chinese Simplified", "zh-CN");
            Langauges.Add("Chinese Traditional", "zh-TW");
            Langauges.Add("Croatian", "hr");
            Langauges.Add("Czech", "cs");
            Langauges.Add("Danish", "da");
            Langauges.Add("Dutch", "nl");
            Langauges.Add("English", "en");
            Langauges.Add("Esperanto", "eo");
            Langauges.Add("Estonian", "et");
            Langauges.Add("Filipino", "tl");
            Langauges.Add("Finnish", "fi");
            Langauges.Add("French", "fr");
            Langauges.Add("Galician", "gl");
            Langauges.Add("Georgian", "ka");
            Langauges.Add("German", "de");
            Langauges.Add("Greek", "el");
            Langauges.Add("Gujarati", "gu");
            Langauges.Add("Haitian Creole", "ht");
            Langauges.Add("Hebrew", "iw");
            Langauges.Add("Hindi", "hi");
            Langauges.Add("Hungarian", "hu");
            Langauges.Add("Icelandic", "is");
            Langauges.Add("Indonesian", "id");
            Langauges.Add("Irish", "ga");
            Langauges.Add("Italian", "it");
            Langauges.Add("Japanese", "ja");
            Langauges.Add("Kannada", "kn");
            Langauges.Add("Korean", "ko");
            Langauges.Add("Latin", "la");
            Langauges.Add("Latvian", "lv");
            Langauges.Add("Lithuanian", "lt");
            Langauges.Add("Macedonian", "mk");
            Langauges.Add("Malay", "ms");
            Langauges.Add("Maltese", "mt");
            Langauges.Add("Norwegian", "no");
            Langauges.Add("Persian", "fa");
            Langauges.Add("Polish", "pl");
            Langauges.Add("Portuguese", "pt");
            Langauges.Add("Romanian", "ro");
            Langauges.Add("Russian", "ru");
            Langauges.Add("Serbian", "sr");
            Langauges.Add("Slovak", "sk");
            Langauges.Add("Slovenian", "sl");
            Langauges.Add("Spanish", "es");
            Langauges.Add("Swahili", "sw");
            Langauges.Add("Swedish", "sv");
            Langauges.Add("Tamil", "ta");
            Langauges.Add("Telugu", "te");
            Langauges.Add("Thai", "th");
            Langauges.Add("Turkish", "tr");
            Langauges.Add("Ukrainian", "uk");
            Langauges.Add("Urdu", "ur");
            Langauges.Add("Vietnamese", "vi");
            Langauges.Add("Welsh", "cy");
            Langauges.Add("Yiddish", "yi");
        }

        public static Langauge GetInstanse()
        {
            return _langauge ?? (_langauge = new Langauge());
        }

        public string GetLanguageShortName(string langaugeName)
        {
            return Langauges.ContainsKey(langaugeName) == false ? null : Langauges[langaugeName];
        }

        public Dictionary<string, string> GetLangauges()
        {
            return Langauges;
        }
    }
}
