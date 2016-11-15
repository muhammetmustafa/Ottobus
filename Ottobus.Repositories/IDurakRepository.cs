using Ottobus.Domain;

namespace Ottobus.Repositories
{
    public interface IDurakRepository : IOrtakRepository<Durak>
    {
        Durak isimIleBul(string isim);
    }
}