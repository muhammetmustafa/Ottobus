using LightCore;
using LightCore.Lifecycle;
using Ottobus.Core.Ayarlar;
using Ottobus.Infrastructure.Oturum;
using Ottobus.Repositories;

namespace Ottobus.Tests
{
    public static class Onyukleyici
    {
        private static IContainer _container;

        public static void onYukle()
        {
            var builder = new ContainerBuilder();
            servisleriKaydet(builder);

            _container = builder.Build();
        }

        public static T bul<T>()
        {
            if (_container == null)
            {
                onYukle();
            }

            return (T) _container.Resolve(typeof (T));
        }

        private static void servisleriKaydet(IContainerBuilder konteynirInsaaci)
        {
            konteynirInsaaci.Register<IOturumFabrikasi, OturumFabrikasi>().ControlledBy<SingletonLifecycle>();

            konteynirInsaaci.Register<IGenelAyarlar, GenelAyarlar>();
            konteynirInsaaci.Register<IDurakRepository, DurakRepository>();
        }
    }
}