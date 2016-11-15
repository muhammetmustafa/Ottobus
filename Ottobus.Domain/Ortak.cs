using System;

namespace Ottobus.Domain
{
    public abstract class Ortak<TId>
    {
        public virtual TId ID { get; set; }

        public virtual DateTime OlusturulmaTarihi { get; set; } = DateTime.Now;

        public virtual DateTime GuncellenmeTarihi { get; set; } = DateTime.Now;

        public virtual DateTime SilinmeTarihi { get; set; }

        public virtual bool SilinmisMi { get; set; } = false;
    }
}