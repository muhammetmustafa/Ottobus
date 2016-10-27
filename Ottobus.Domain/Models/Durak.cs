using System;

namespace Ottobus.Domain.Models
{
    public class Durak
    {
        public virtual long ID { get; set; }

        public virtual string Ad { get; set; }

        public virtual double Enlem { get; set; }

        public virtual double Boylam { get; set; }
    }
}
