using System.Collections.Generic;

namespace Ottobus.Domain
{
    public class Durak : Ortak<long>
    {
        public virtual string Ad { get; set; }

        public virtual double Enlem { get; set; }

        public virtual double Boylam { get; set; }

        public virtual IList<Guzergah> Guzergahlar { get; set; }
    }
}