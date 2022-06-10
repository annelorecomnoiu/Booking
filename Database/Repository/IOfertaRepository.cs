using booking.Database.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace booking.Database.Repository
{
    public interface IOfertaRepository : IRepositoryBase<Oferta>
    {
        Task AddOferta(string numeOferta, float pretOferta, Camera camera, DateTime dataStart, DateTime dataEnd);

        bool DeleteOferta(string numeOferta);

    }
}
