using System.Collections.Generic;

namespace TranslatorLib.Setting
{
    public interface IConfiguration
    {
        object Get(string settingName);

        void Set(string settingName, object settingValue);

        void Set(Dictionary<string, object> settingArray);

        void Save();
    }
}
