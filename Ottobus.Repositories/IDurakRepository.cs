using System;
using Ottobus.Domain.Models;

namespace Ottobus.Repositories
{
    public interface IDurakRepository
    {
        void ekle(Durak durak);

        void guncelle(Durak durak);

        void sil(Durak durak);

        Durak idIleBul(Guid id);

        Durak isimIleBul(string isim);
    }
}