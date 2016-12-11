using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ottobus.Domain;
using Ottobus.Repositories;

namespace Ottobus.Tests.DomainTests
{
    [TestClass]
    public class HatRepositoryTest
    {
        private readonly IHatRepository _hatRepository = Onyukleyici.bul<IHatRepository>();
        private readonly IDurakRepository _durakRepository = Onyukleyici.bul<IDurakRepository>();

        [TestMethod]
        public void HatEkle()
        {
            Hat hat = Onyukleyici.bul<Hat>();
            hat.HatAdi = "79K";

            _hatRepository.kaydetGuncelle(hat);
        }

        [TestMethod]
        public void GuzergahliHatEkle()
        {
            Hat hat = Onyukleyici.bul<Hat>();
            hat.HatAdi = "79K";
            
            var durak = _durakRepository.isimIleBul("elmas");
            if (durak == null)
            {
                Console.WriteLine("Durak bulunamadı!");
                return;
            }

            Console.WriteLine(durak.ID + " " + durak.Ad);

            hat.guzergahEkle(durak, 2);

            _hatRepository.kaydetGuncelle(hat);
        }
    }
}
