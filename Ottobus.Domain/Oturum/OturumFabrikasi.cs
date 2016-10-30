using FluentNHibernate.Automapping;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using Ottobus.Core.Ayarlar;
using Ottobus.Domain.Models;

namespace Ottobus.Domain.Oturum
{
    public class OturumFabrikasi : IOturumFabrikasi
    {
        private const string CurrentSessionKey = "nhibernate.current_session";

        private readonly IGenelAyarlar _ayarlar;
        private readonly ISessionFactory _oturumFabrikasi;

        private ISession _oturum;

        public OturumFabrikasi(IGenelAyarlar ayarlar)
        {
            _ayarlar = ayarlar;

            _oturumFabrikasi = oturumFabrikasiOlustur();
        }

        private static ISessionFactory oturumFabrikasiOlustur()
        {
            var autoMappings = new AutoPersistenceModel()
                  .AddMappingsFromAssemblyOf<Ortak>()
                  .IgnoreBase<Ortak>()
                  .Where(t => t.Namespace == "Ottobus.Domain");

            return
            Fluently.Configure()
            .Database(PostgreSQLConfiguration.Standard
                .ConnectionString(c => c
                    .Host("localhost")
                    .Username("postgres")
                    .Password("626243121")
                    .Port(5432)
                    .Database("ottobus"))
                .ShowSql()
            )
            .Mappings(m => m.AutoMappings.Add(autoMappings))
            .ExposeConfiguration(cfg => new SchemaUpdate(cfg).Execute(true, true))
            .BuildSessionFactory();
        }

        public ISession oturumAc()
        {
            if (_oturum != null)
            {
                _oturum = _oturumFabrikasi.OpenSession();
            }

            return _oturum;
        }
    }
}