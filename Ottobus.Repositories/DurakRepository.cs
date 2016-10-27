using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using Ottobus.Domain.Models;

namespace Ottobus.Repositories
{
    public class DurakRepository : IDurakRepository
    {
        public void ekle(Durak durak)
        {
            using (ISession session = HibernateUtil.sessionFactory.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Save(durak);
                    transaction.Commit();
                }
            }
        }

        public void guncelle(Durak durak)
        {
            using (ISession session = HibernateUtil.sessionFactory.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Update(durak);
                    transaction.Commit();
                }
            }
        }

        public void sil(Durak durak)
        {
            using (ISession session = HibernateUtil.sessionFactory.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Delete(durak);
                    transaction.Commit();
                }
            }
        }

        public Durak idIleBul(Guid id)
        {
            throw new NotImplementedException();
        }

        public Durak isimIleBul(string isim)
        {
            throw new NotImplementedException();
        }
    }
}
