using booking.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace booking.Database.Repository
{
    public interface IServiciiRezervareRepository : IRepositoryBase<ServiciiRezervare>
    {
        bool AddServicii(List<Serviciu> servicii, Rezervare rezervari);
    }
}
