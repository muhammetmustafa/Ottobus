﻿using NHibernate;

namespace Ottobus.Data.Oturum
{
    public interface IOturumFabrikasi
    {
        ISession oturumAc();
    }
}