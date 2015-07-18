using System.Collections.Generic;

using Moq;
using TranslatorLib;
using TranslatorLib.Google.Exceptions;
using TranslatorLib.Google;
using Xunit;
using Assert = Xunit.Assert;

namespace TranslatorLibTest
{
    public class TanslateTest
    {
        private const string dummyGoogleResponse = "{'data': {'translations': [{'translatedText': 'આકાર'}]}}";

        [Fact]
        public void EnglishToGujaratiTest()
        {
            const string Input = "Aakar";

            var googleRequestMock = new Mock<IGoogleRequest>();
            googleRequestMock.Setup(request => request.Execute(It.IsAny<string>())).Returns(dummyGoogleResponse);
            ITranslate translator = new GoogleTranslator(googleRequestMock.Object);

            List<string> result = translator.Translate(Input, "English", "Gujarati");
            Assert.Equal(result[0], "આકાર");
        }

        [Fact]
        public void UnknownLanguageTest()
        {
            const string Input = "Aakar";

            var googleRequestMock = new Mock<IGoogleRequest>();
            googleRequestMock.Setup(request => request.Execute(It.IsAny<string>())).Returns(string.Empty);
            ITranslate translator = new GoogleTranslator(googleRequestMock.Object);

            var ex = Assert.Throws<NoLanguageSupportException>(() => translator.Translate(Input, "English1", "Gujarati"));
            Assert.Equal("Invalid Langauge Name", ex.Message);
        }

        [Fact]
        public void NoContentFoundLanguageTest()
        {
            const string Input = "Aakar";

            var googleRequestMock = new Mock<IGoogleRequest>();
            googleRequestMock.Setup(request => request.Execute(It.IsAny<string>())).Throws<NoContentFoundException>();
            ITranslate translator = new GoogleTranslator(googleRequestMock.Object);

            var ex = Assert.Throws<NoContentFoundException>(() => translator.Translate(Input, "English", "Gujarati"));
            Assert.Equal("Exception of type 'TranslatorLib.Google.Exceptions.NoContentFoundException' was thrown.", ex.Message);
        }

        [Fact]
        public void GetAllSupportedLangaugesTest()
        {
            Langauge language = Langauge.GetInstanse();
            DummyLanguage dummyLanguage = new DummyLanguage();

            Dictionary<string, string> langauages = language.GetLangauges();
            Dictionary<string, string> dummyLangauges = dummyLanguage.Langauges;

            foreach (KeyValuePair<string, string> lang in langauages)
            {
                Assert.True(dummyLangauges.ContainsKey(lang.Key));
                string langValue = dummyLangauges[lang.Key];
                Assert.Equal(langValue, lang.Value);
            }
        }
    }
}
