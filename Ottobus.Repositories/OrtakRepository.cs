using NHibernate;
using Ottobus.Infrastructure.Oturum;

namespace Ottobus.Repositories
{
    public class OrtakRepository<T> : IOrtakRepository<T>
    {
        protected readonly IOturumFabrikasi _oturumFabrikasi;

        public OrtakRepository(IOturumFabrikasi oturumFabrikasi)
        {
            _oturumFabrikasi = oturumFabrikasi;
        }

        public void kaydetGuncelle(T nesne)
        {
            using (var oturum = _oturumFabrikasi.oturumAc())
            {
                using (var transaction = oturum.BeginTransaction())
                {
                    oturum.SaveOrUpdate(nesne);
                    transaction.Commit();
                }
            }
        }
        

        public void sil(T nesne)
        {
            using (var oturum = _oturumFabrikasi.oturumAc())
            {
                using (var transaction = oturum.BeginTransaction())
                {
                    oturum.Delete(nesne);
                    transaction.Commit();
                }
            }
        }

        public T idIleBul(long id)
        {
            using (var oturum = _oturumFabrikasi.oturumAc())
            {
                return oturum.Get<T>(id);
            }
        }
    }
}