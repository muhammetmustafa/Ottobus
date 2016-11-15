using NHibernate;

namespace Ottobus.Infrastructure.Oturum
{
    public interface IOturumFabrikasi
    {
        ISession oturumAc();
    }
}