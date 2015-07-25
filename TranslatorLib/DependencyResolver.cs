using System.Diagnostics.CodeAnalysis;

using LightInject;
using TranslatorLib.Google;

namespace TranslatorLib
{
    [ExcludeFromCodeCoverage]
    public class DependencyResolver : ICompositionRoot
    {
        public void Compose(IServiceRegistry serviceRegistry)
        {
            serviceRegistry.Register<IWebRequestFactory, WebRequestFactory>();
            serviceRegistry.Register<IGoogleRequest, GoogleRequest>();
            serviceRegistry.Register<ITranslate, GoogleTranslator>();
        }
    }
}
