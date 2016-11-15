using System.Globalization;
using System.Linq;
using NHibernate;
using NHibernate.Linq;
using Ottobus.Domain;
using Ottobus.Infrastructure.Oturum;

namespace Ottobus.Repositories
{
    public class DurakRepository : OrtakRepository<Durak>, IDurakRepository
    {
        public DurakRepository(IOturumFabrikasi oturumFabrikasi) : base(oturumFabrikasi)
        {
        }

        public Durak isimIleBul(string isim)
        {
            var _isim = isim.ToLower(CultureInfo.CurrentCulture);

            using (var oturum = _oturumFabrikasi.oturumAc())
            {
                return oturum.Query<Durak>().FirstOrDefault(d => 
                    d.Ad.ToLower() == _isim || 
                    d.Ad.ToLower().Contains(_isim));
            }
        }
    }
}
