using booking.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace booking.Database.Repository
{
    public interface IRezervareRepository : IRepositoryBase<Rezervare>
    {
        Task AddRezervare(int idUser, int idCamera, int idOferta, int nrCamere, DateTime dataStart, DateTime dataEnd);
    }
}
