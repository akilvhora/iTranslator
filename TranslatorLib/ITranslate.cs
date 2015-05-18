using System.Collections.Generic;

namespace TranslatorLib
{
    public interface ITranslate
    {
        List<string> Translate(string input, string fromLangauge, string toLangauge);
    }
}
