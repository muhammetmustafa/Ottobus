namespace Ottobus.Domain.Mappings
{
    public class OtobusMap : OrtakMap<Otobus, long>
    {
        public OtobusMap()
        {
            Table("otobusler");

            Map(x => x.Marka).Column("marka").Not.Nullable();
            Map(x => x.Model).Column("model").Not.Nullable();
        }
    }
}