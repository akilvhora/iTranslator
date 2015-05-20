using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TranslatorLib;
using TranslatorLib.Google;
using Xunit;
using Assert = Xunit.Assert;

namespace TranslatorLibTest
{
    public class TanslateTest
    {
        private ITranslate translator;

        public TanslateTest()
        {
            translator = new GoogleTranslator();
        }

        [Fact]
        public void EnglishToGujaratiTest()
        {
            const string input = "Aakar";
            translator = new GoogleTranslator();
            List<string> result = translator.Translate(input, "English", "Gujarati");
            Assert.Equal(result[0], "આકાર");
        }

        [Fact]
        public void UnknownLanguageTest()
        {
            const string input = "Aakar";
            var ex = Assert.Throws<Exception>(() => translator.Translate(input, "English1", "Gujarati"));
            Assert.Equal("Invalid Langauge Name", ex.Message);
        }

        [Fact]
        public void GetAllSupportedLangaugesTest()
        {
            Langauge language = Langauge.GetInstanse();
            LanguageMock mockLanguage = new LanguageMock();

            Dictionary<string, string> langauages = language.GetLangauges();
            Dictionary<string, string> mockLangauges = mockLanguage.Langauges;

            foreach (KeyValuePair<string, string> lang in langauages)
            {
                Assert.True(mockLangauges.ContainsKey(lang.Key));
                string langValue = mockLangauges[lang.Key];
                Assert.Equal(langValue, lang.Value);
            }
        }
    }
}
