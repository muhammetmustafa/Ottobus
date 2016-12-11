using System;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ottobus.Domain;
using Ottobus.Repositories;

namespace Ottobus.Tests.DomainTests
{
    [TestClass]
    public class DurakRepositoryTest
    {
        private readonly IDurakRepository _durakRepository = Onyukleyici.bul<IDurakRepository>();
        

        private Durak yeniDurak()
        {
            return Onyukleyici.bul<Durak>();
        }

        [TestMethod]
        public void DurakEklemeTesti()
        {
            var durak = yeniDurak();
            durak.Ad = "ÇInaaar Caddesi Durağı";
            durak.Enlem = 3.4424d;
            durak.Boylam = 35.34234d;

            _durakRepository.kaydetGuncelle(durak);
        }

        [TestMethod]
        public void DurakGuncellemeTesti()
        {
            var durak = yeniDurak();
            durak.Ad = "Elmas Sitesi";
            durak.Enlem = 334.4424d;
            durak.Boylam = 35.34234d;

            _durakRepository.kaydetGuncelle(durak);
        }

        [TestMethod]
        public void DurakSilmeTesti()
        {
            var durak = yeniDurak();
            durak.Ad = "Elmas Sitesi";

            _durakRepository.sil(durak);
        }

        [TestMethod]
        public void DurakBulmaTestiIdIle()
        {
            var durak = _durakRepository.idIleBul(11);

            if (durak == null)
            {
                Console.WriteLine("Bulunamadı");
            }
            else
            {
                Console.WriteLine(durak.ID + " " + durak.Ad);
            }
        }

        [TestMethod]
        public void DurakBulmaTestiIsimIle()
        {
            var durak = _durakRepository.isimIleBul("çınar");

            if (durak == null)
            {
                Console.WriteLine("Bulunamadı");
            }
            else
            {
                Console.WriteLine(durak.ID + " " + durak.Ad);
            }
        }
    }
}
