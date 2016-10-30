using FluentNHibernate.Automapping;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using Ottobus.Domain.Models;

namespace Ottobus.Domain
{
    public class HibernateUtil
    {
        private const string CurrentSessionKey = "nhibernate.current_session";
        public static readonly ISessionFactory sessionFactory;

        static HibernateUtil()
        {
            sessionFactory = createSessionFactory();
        }

        private static ISessionFactory createSessionFactory()
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

       
        public static void closeSessionFactory()
        {
            if (sessionFactory != null)
            {
                sessionFactory.Close();
            }
        }
    }
}