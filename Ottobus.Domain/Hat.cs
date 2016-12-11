using System.Collections.Generic;

namespace Ottobus.Domain
{
    public class Hat : Ortak<long>
    {
        public virtual string HatAdi { get; set; }

        public virtual IList<Guzergah> Guzergahlar { get; protected set; }

        public virtual void guzergahEkle(Durak durak, int ugramaSirasi)
        {
            if (Guzergahlar == null)
                Guzergahlar = new List<Guzergah>();

            Guzergahlar.Add(new Guzergah()
            {
                Hat = this,
                UgramaSirasi = ugramaSirasi,
                Durak = durak
            });
        }
    }
}