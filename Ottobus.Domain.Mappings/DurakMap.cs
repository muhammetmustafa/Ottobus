using FluentNHibernate.Mapping;

namespace Ottobus.Domain.Mappings
{
    public class DurakMap : OrtakMap<Durak, long>
    {
        public DurakMap()
        {
            Table("duraklar");

            Map(x => x.Ad).Column("ad").Not.Nullable();
            Map(x => x.Enlem).Column("enlem").Not.Nullable();
            Map(x => x.Boylam).Column("boylam").Not.Nullable();

            HasMany(x => x.Guzergahlar).LazyLoad();
        }
    }
}