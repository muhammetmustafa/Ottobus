using System.Linq;
using NHibernate;
using NHibernate.Linq;
using Ottobus.Domain;
using Ottobus.Infrastructure.Oturum;

namespace Ottobus.Repositories
{
    public class OtobusRepository : OrtakRepository<Otobus>, IOtobusRepository
    {
        public OtobusRepository(IOturumFabrikasi oturumFabrikasi) : base(oturumFabrikasi)
        {
        }
    }
}