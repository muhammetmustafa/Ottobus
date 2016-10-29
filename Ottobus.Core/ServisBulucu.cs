using LightCore;
using LightCore.Configuration;
using LightCore.Registration;

namespace Ottobus.Core
{
    public static class ServisBulucu
    {
        private static IContainer _container;

        public static T bul<T>()
        {
            if (_container == null)
            {
                ayarla("LightCore.config");
            }

            return (T) _container.Resolve(typeof (T));
        }

        public static void ayarla(string dosyaAdi)
        {
            if (_container == null)
            {
                return;
            }

            var builder = new ContainerBuilder();
            RegistrationModule xamlModule = new XamlRegistrationModule(dosyaAdi);
            builder.RegisterModule(xamlModule);
            _container = builder.Build();
        }
    }
}