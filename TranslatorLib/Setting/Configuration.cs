using System.Collections.Generic;

namespace TranslatorLib.Setting
{
    public class Configuration : IConfiguration
    {
        public object Get(string settingName)
        {
            return Settings.Default[settingName];
        }

        public void Set(string settingName, object settingValue)
        {
            Settings.Default[settingName] = settingValue;
        }

        public void Set(Dictionary<string, object> settings)
        {
            foreach (KeyValuePair<string, object> setting in settings)
            {
                Set(setting.Key, setting.Value);
            }
        }

        public void Save()
        {
            Settings.Default.Save();
        }
    }
}
