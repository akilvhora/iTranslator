using System.Diagnostics.CodeAnalysis;

using LightInject;
using TranslatorLib.Google;

namespace TranslatorLib
{
    [ExcludeFromCodeCoverage]
    public class DependencyResolver : ICompositionRoot
    {
        private static readonly ServiceContainer Container = new ServiceContainer();

        public void Compose(IServiceRegistry serviceRegistry)
        {
            Container.Register<ITranslate, GoogleTranslator>();
            Container.Register<IWebRequestFactory, WebRequestFactory>();
            Container.Register<IGoogleRequest, GoogleRequest>();
        }
    }
}
