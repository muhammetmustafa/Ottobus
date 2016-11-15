namespace Ottobus.Domain
{
    public class Guzergah : Ortak<long>
    {
        public virtual Hat Hat { get; set; }

        public virtual Durak Durak { get; set; }

        public virtual int UgramaSirasi { get; set; }
    }
}