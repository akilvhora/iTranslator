
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace TranslatorLib.Google
{
    [DataContract]
    class GoogleTranslation
    {
        [DataMember(Name = "data")]
        public Data Data { get; set; }
    }

    [DataContract]
    class Data
    {
        [DataMember(Name = "translations")]
        public List<Translation> Translations { get; set; }
    }

    [DataContract]
    class Translation
    {
        [DataMember(Name = "translatedText")]
        public string TranslatedText { get; set; }
    }
}
