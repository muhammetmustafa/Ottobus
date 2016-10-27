using System.Reflection;
using System.Web;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using Ottobus.Domain.Models;

namespace Ottobus.Repositories
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
            Assembly assembly = Assembly.GetAssembly(typeof (Durak));

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
            .Mappings(m => 
                m.FluentMappings.AddFromAssembly(assembly)
            )
            .ExposeConfiguration(cfg => new SchemaUpdate(cfg).Execute(true, true))
            .BuildSessionFactory();
        }

        public static ISession getCurrentSession()
        {
            HttpContext context = HttpContext.Current;
            ISession currentSession = context.Items[CurrentSessionKey] as ISession;

            if (currentSession == null)
            {
                currentSession = sessionFactory.OpenSession();
                context.Items[CurrentSessionKey] = currentSession;
            }

            return currentSession;
        }

        public static void closeSession()
        {
            HttpContext context = HttpContext.Current;
            ISession currentSession = context.Items[CurrentSessionKey] as ISession;

            if (currentSession == null)
            {
                // No current session
                return;
            }

            currentSession.Close();
            context.Items.Remove(CurrentSessionKey);
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