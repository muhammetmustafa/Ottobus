namespace Ottobus.Domain.Mappings
{
    public class HatMap : OrtakMap<Hat, long>
    {
        public HatMap()
        {
            Table("hatlar");

            Map(x => x.HatAdi).Column("hat_adi").Not.Nullable();

            HasMany(x => x.Guzergahlar).LazyLoad();
        }
    }
}