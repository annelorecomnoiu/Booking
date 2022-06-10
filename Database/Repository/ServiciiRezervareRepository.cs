using booking.Database.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace booking.Database.Repository
{
    public class ServiciiRezervareRepository : RepositoryBase<ServiciiRezervare>, IServiciiRezervareRepository
    {
        public ServiciiRezervareRepository(BookingContext context) : base(context)
        {

        }

        public bool AddServicii(List<Serviciu> servicii, Rezervare rezervari)
        {
            foreach (var serviciu in servicii)
            {
                Insert(new ServiciiRezervare()
                { Rezervare = rezervari, IdRezervare = rezervari.Id, Serviciu = serviciu, IdServiciu = serviciu.Id });
            }
            return true;
        }
    }
}