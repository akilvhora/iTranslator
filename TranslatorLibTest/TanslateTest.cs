using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

using Moq;
using TranslatorLib;
using TranslatorLib.Google;
using TranslatorLib.Google.Exceptions;
using Xunit;
using Assert = Xunit.Assert;

namespace TranslatorLibTest
{
    public class TanslateTest
    {
        private const string _dummyGoogleResponse = "{'data': {'translations': [{'translatedText': 'આકાર'}]}}";
        private const string _input = "Aakar";

        [Fact]
        public void EnglishToGujaratiTest()
        {
            var googleRequestMock = new Mock<IGoogleRequest>();
            googleRequestMock.Setup(request => request.Execute(It.IsAny<string>())).Returns(_dummyGoogleResponse);
            ITranslate translator = new GoogleTranslator(googleRequestMock.Object);

            List<string> result = translator.Translate(_input, "English", "Gujarati");
            Assert.Equal(result[0], "આકાર");
        }

        [Fact]
        public void UnknownLanguageTest()
        {
            var googleRequestMock = new Mock<IGoogleRequest>();
            googleRequestMock.Setup(request => request.Execute(It.IsAny<string>())).Returns(string.Empty);
            ITranslate translator = new GoogleTranslator(googleRequestMock.Object);

            var ex = Assert.Throws<NoLanguageSupportException>(() => translator.Translate(_input, "English1", "Gujarati"));
            Assert.Equal("Invalid Langauge Name", ex.Message);
        }

        [Fact]
        public void NoContentFoundLanguageTest()
        {
            var googleRequestMock = new Mock<IGoogleRequest>();
            googleRequestMock.Setup(request => request.Execute(It.IsAny<string>())).Throws(new NoContentFoundException("No Content Found"));
            ITranslate translator = new GoogleTranslator(googleRequestMock.Object);

            var ex = Assert.Throws<NoContentFoundException>(() => translator.Translate(_input, "English", "Gujarati"));
            Assert.Equal("No Content Found", ex.Message);
        }

        [Fact]
        public void GoogleRequestTest()
        {
            var expectedBytes = Encoding.UTF8.GetBytes(_dummyGoogleResponse);
            var responseStream = new MemoryStream();
            responseStream.Write(expectedBytes, 0, expectedBytes.Length);
            responseStream.Seek(0, SeekOrigin.Begin);

            var webResponseMock = new Mock<HttpWebResponse>();
            webResponseMock.Setup(response => response.GetResponseStream()).Returns(responseStream);

            var webRequestMock = new Mock<WebRequest>();
            webRequestMock.Setup(request => request.GetResponse()).Returns(webResponseMock.Object);

            var requestMock = new Mock<IWebRequestFactory>();
            requestMock.Setup(factory => factory.Create(It.IsAny<string>())).Returns(webRequestMock.Object);

            IGoogleRequest googleRequest = new GoogleRequest(requestMock.Object);
            var result = googleRequest.Execute("http://www.google.com");

            Assert.Equal(result, _dummyGoogleResponse);
        }

        [Fact]
        public void GoogleRequestContentNotFoundTest()
        {
            var webResponseMock = new Mock<HttpWebResponse>();
            webResponseMock.Setup(response => response.GetResponseStream()).Returns(() => null);

            var webRequestMock = new Mock<WebRequest>();
            webRequestMock.Setup(request => request.GetResponse()).Returns(webResponseMock.Object);

            var requestMock = new Mock<IWebRequestFactory>();
            requestMock.Setup(factory => factory.Create(It.IsAny<string>())).Returns(webRequestMock.Object);

            IGoogleRequest googleRequest = new GoogleRequest(requestMock.Object);
            var ex = Assert.Throws<NoContentFoundException>(() => googleRequest.Execute("http://www.google.com"));

            Assert.Equal("No Content Found", ex.Message);
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
