using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TranslatorLib;
using TranslatorLib.Google;

namespace TranslatorLibTest
{
    [TestClass]
    public class TanslateTest
    {
        [TestMethod]
        public void EnglishToGujarati()
        {
            const string input = "Aakar";
            ITranslate translator = new GoogleTranslator();
            List<string> result = translator.Translate(input, "English", "Gujarati");
            Assert.AreEqual(result[0], "આકાર");
        }
    }
}
