using System;
using NHibernate.Tuple;

namespace Ottobus.Domain
{
    public abstract class Ortak
    {
        public virtual long ID { get; set; }

        public virtual DateTime OlusturulmaTarihi { get; set; }

        public virtual DateTime SilinmeTarihi { get; set; }

        public virtual bool SilinmisMi { get; set; }
    }
}