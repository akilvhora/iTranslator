using System;
using System.Collections.Generic;
using TranslatorLib;
using TranslatorLib.Google;
using Xunit;
using Assert = Xunit.Assert;

namespace TranslatorLibTest
{
    public class TanslateTest
    {
        private ITranslate _translator;

        public TanslateTest()
        {
            _translator = new GoogleTranslator();
        }

        [Fact]
        public void EnglishToGujaratiTest()
        {
            const string input = "Aakar";
            _translator = new GoogleTranslator();
            List<string> result = _translator.Translate(input, "English", "Gujarati");
            Assert.Equal(result[0], "આકાર");
        }

        [Fact]
        public void UnknownLanguageTest()
        {
            const string input = "Aakar";
            var ex = Assert.Throws<Exception>(() => _translator.Translate(input, "English1", "Gujarati"));
            Assert.Equal("Invalid Langauge Name", ex.Message);
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
