using Ottobus.Domain;
using Ottobus.Infrastructure.Oturum;

namespace Ottobus.Repositories
{
    public class HatRepository : OrtakRepository<Hat>, IHatRepository
    {
        public HatRepository(IOturumFabrikasi oturumFabrikasi) : base(oturumFabrikasi)
        {
        }
    }
}