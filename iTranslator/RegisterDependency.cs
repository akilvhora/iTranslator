using LightInject;
using TranslatorLib;
using TranslatorLib.Google;

namespace iTranslator
{
    public class RegisterDependency
    {
        public static readonly ServiceContainer Container = new ServiceContainer();

        public static void Register()
        {
            Container.Register<IWebRequestFactory, WebRequestFactory>();
            Container.Register<IGoogleRequest, GoogleRequest>();
            Container.Register<ITranslate, GoogleTranslator>();
        }
    }
}
