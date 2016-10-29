using NHibernate;

namespace Ottobus.DataLayer.Oturum
{
    public interface IOturumFabrikasi
    {
        ISession oturumAc();
    }
}