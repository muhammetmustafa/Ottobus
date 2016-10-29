using FluentNHibernate.Mapping;
using FluentNHibernate.MappingModel.ClassBased;

namespace Ottobus.Domain
{
    public class OrtakMap<T> : ClassMap<T> where T : Ortak
    {
        public OrtakMap()
        { 
            Id(x => x.ID).Column("id").Not.Nullable();
            Map(x => x.OlusturulmaTarihi).Column("olusturulma_tarihi").Not.Nullable();
            Map(x => x.SilinmeTarihi).Column("silinme_tarihi").Not.Nullable();
            Map(x => x.SilinmisMi).Column("silinmis_mi").Not.Nullable();
        }
    }
}