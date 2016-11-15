using FluentNHibernate.Mapping;

namespace Ottobus.Domain.Mappings
{
    public class OrtakMap<TBase, TBaseId> : ClassMap<TBase> where TBase : Ortak<TBaseId>
    {
        public OrtakMap()
        { 
            Id(x => x.ID).Column("id").Not.Nullable().GeneratedBy.Native();

            Map(x => x.OlusturulmaTarihi).Column("olusturulma_tarihi").Not.Nullable();

            Map(x => x.GuncellenmeTarihi).Column("guncellenme_tarihi").Not.Nullable();

            Map(x => x.SilinmeTarihi).Column("silinme_tarihi").Nullable();

            Map(x => x.SilinmisMi).Column("silinmis_mi").Not.Nullable();
        }
    }
}