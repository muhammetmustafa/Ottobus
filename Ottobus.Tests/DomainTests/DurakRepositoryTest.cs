using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ottobus.Domain.Models;
using Ottobus.Repositories;

namespace Ottobus.Tests.DomainTests
{
    [TestClass]
    public class DurakRepositoryTest
    {
        [TestMethod]
        public void DurakEklemeTesti()
        {
            IDurakRepository durakRepository = new DurakRepository();
            durakRepository.ekle(new Durak()
            {
                Ad="Oltu Sitesi",
                Boylam = 23.342222d,
                Enlem = 31.34223342d
            });
        }

        [TestMethod]
        public void DurakGuncellemeTesti()
        {
            IDurakRepository durakRepository = new DurakRepository();
            durakRepository.guncelle(new Durak()
            {
                Ad = "Oltu Sitesi",
                Boylam = 1.34d,
                Enlem = 1.34d
            });
        }
    }
}
