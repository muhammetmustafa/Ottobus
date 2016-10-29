using FluentNHibernate.Mapping;
using NHibernate.Mapping.ByCode;

namespace Ottobus.Domain.Models
{
    public class DurakMap : OrtakMap<Durak>
    {
        public DurakMap()
        {
            Table("duraklar");

            Map(x => x.Ad).Not.Nullable();
            Map(x => x.Enlem).Not.Nullable();
            Map(x => x.Boylam).Not.Nullable();
        }
    }
}