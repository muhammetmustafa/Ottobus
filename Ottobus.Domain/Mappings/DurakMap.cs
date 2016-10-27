using FluentNHibernate.Mapping;
using Ottobus.Domain.Models;

namespace Ottobus.Domain.Mappings
{
    public class DurakMap : ClassMap<Durak>
    {
        public DurakMap()
        {
            Table("duraklar");
            Id(x => x.ID);
            Map(x => x.Ad).Not.Nullable();
            Map(x => x.Enlem).Not.Nullable();
            Map(x => x.Boylam).Not.Nullable();
        }
    }
}