using FluentNHibernate.Conventions.Helpers;
using FluentNHibernate.Mapping;

namespace Ottobus.Domain.Mappings
{
    public class GuzergahMap : OrtakMap<Guzergah, long>
    {
        public GuzergahMap()
        {
            Table("guzergahlar");

            Map(x => x.UgramaSirasi).Column("ugrama_sirasi").Not.Nullable();
            HasOne(x => x.Hat).LazyLoad(Laziness.Proxy);
            HasOne(x => x.Durak).LazyLoad(Laziness.Proxy);
        }
    }
}