using booking.Database.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace booking.Database.Repository
{
    public class ServiciiOfertaRepository : RepositoryBase<ServiciiOferta>, IServiciiOferta
    {
        public ServiciiOfertaRepository(BookingContext context) : base(context)
        {

        }

        public bool AddServicii(List<Serviciu> servicii, Oferta oferte)
        {
            foreach (var serviciu in servicii)
            {
                Insert(new ServiciiOferta()
                { Oferta = oferte, IdOferta = oferte.Id, Serviciu = serviciu, IdServiciu = serviciu.Id });
            }
            return true;
        }
    }
}
