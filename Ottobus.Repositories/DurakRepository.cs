using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using Ottobus.Core;
using Ottobus.DataLayer.Oturum;
using Ottobus.Domain.Models;

namespace Ottobus.Repositories
{
    public class DurakRepository : IDurakRepository
    {
        public void ekle(Durak durak)
        {
            using (var session = ServisBulucu.bul<IOturumFabrikasi>().oturumAc())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Save(durak);
                    transaction.Commit();
                }
            }
        }

        public void guncelle(Durak durak)
        {
            using (var session = ServisBulucu.bul<IOturumFabrikasi>().oturumAc())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Update(durak);
                    transaction.Commit();
                }
            }
        }

        public void sil(Durak durak)
        {
            using (var session = ServisBulucu.bul<IOturumFabrikasi>().oturumAc())
            {
                using (var transaction = session.BeginTransaction())
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
