using booking.Database.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace booking.Database.Repository
{
    public interface IServiciiOferta : IRepositoryBase<ServiciiOferta>
    {
        bool AddServicii(List<Serviciu> servicii, Oferta oferte);
    }
}
