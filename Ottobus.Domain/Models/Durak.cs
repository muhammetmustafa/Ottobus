using System;

namespace Ottobus.Domain.Models
{
    public class Durak : Ortak
    {
        public virtual string Ad { get; set; }

        public virtual double Enlem { get; set; }

        public virtual double Boylam { get; set; }
    }
}
