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

        private IDurakRepository yeniDurakRepository<TId>()
        {
            return Onyukleyici.bul<IDurakRepository>();
        }

        private Durak yeniDurak<TId>()
        {
            return Onyukleyici.bul<Durak>();
        }

        [TestMethod]
        public void DurakEklemeTesti()
        {
            var durak = yeniDurak<long>();
            durak.Ad = "ÇInaaar Caddesi Durağı";
            durak.Enlem = 3.4424d;
            durak.Boylam = 35.34234d;

            yeniDurakRepository<long>()
            .kaydetGuncelle(durak);
        }

        [TestMethod]
        public void DurakGuncellemeTesti()
        {
            var durak = yeniDurak<long>();
            durak.Ad = "Elmas Sitesi";
            durak.Enlem = 334.4424d;
            durak.Boylam = 35.34234d;

            yeniDurakRepository<long>()
            .guncelle(durak);
        }

        [TestMethod]
        public void DurakSilmeTesti()
        {
            var durak = yeniDurak<long>();
            durak.Ad = "Elmas Sitesi";

            yeniDurakRepository<long>()
            .sil(durak);
        }

        [TestMethod]
        public void DurakBulmaTestiIdIle()
        {
            var durak = yeniDurakRepository<long>().idIleBul(11);

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
            var durak = yeniDurakRepository<long>().isimIleBul("çınar");

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
