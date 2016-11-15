using System.Collections.Generic;

namespace Ottobus.Domain
{
    public class Hat : Ortak<long>
    {
        public virtual string HatAdi { get; set; }

        public virtual List<Guzergah> Guzergahlar { get; set; }
    }
}