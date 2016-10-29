

namespace Ottobus.Core.Ayarlar
{
    public class GenelAyarlar : IGenelAyarlar
    {
        public string BaglantiBilgileri => Properties.Settings.Default.BaglantiBilgileri;
    }
}