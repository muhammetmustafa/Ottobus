﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ottobus.Domain.Models;
using Ottobus.Repositories;

namespace Ottobus.Tests.DomainTests
{
    [TestClass]
    public class DurakRepositoryTest
    {
        [TestInitialize]
        public void onyukleme()
        {
            Onyukleyici.onYukle();   
        }

        [TestMethod]
        public void DurakEklemeTesti()
        {
            IDurakRepository durakRepository = Onyukleyici.bul<IDurakRepository>();
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
            IDurakRepository durakRepository = Onyukleyici.bul<IDurakRepository>();
            durakRepository.guncelle(new Durak()
            {
                Ad = "Oltu Sitesi",
                Boylam = 1.3433d,
                Enlem = 1.3334d
            });
        }
    }
}
