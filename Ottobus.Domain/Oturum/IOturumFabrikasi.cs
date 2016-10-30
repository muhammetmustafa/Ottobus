using NHibernate;

namespace Ottobus.Domain.Oturum
{
    public interface IOturumFabrikasi
    {
        ISession oturumAc();
    }
}