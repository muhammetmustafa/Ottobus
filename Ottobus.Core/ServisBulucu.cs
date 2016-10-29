using System;
using LightCore;
using LightCore.Configuration;
using LightCore.Registration;
using Ottobus.Core.Ayarlar;

namespace Ottobus.Core
{
    public static class ServisBulucu
    {
        private static IContainer _container;

        public static T bul<T>()
        {
            if (_container == null)
            {
                ayarla();
            }
            if (_container == null)
            {
                throw new Exception("Konteynır hatası!");
            }

            return (T) _container.Resolve(typeof (T));
        }

        public static void ayarla()
        {
            var builder = new ContainerBuilder();
            RegistrationModule xamlModule = new XamlRegistrationModule("lightcore.config");
            builder.RegisterModule(xamlModule);
            _container = builder.Build();
        }
    }
}