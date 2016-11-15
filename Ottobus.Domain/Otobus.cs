namespace Ottobus.Domain
{
    public class Otobus : Ortak<long>
    {
        public virtual string Marka { get; set; }

        public virtual string Model { get; set; }
    }
}