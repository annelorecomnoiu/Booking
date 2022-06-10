using booking.Database.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace booking.Database.Repository
{
    public interface IPretRepository : IRepositoryBase<Pret>
    {
        public Task AddPretAsync(Camera camera, DateTime dataStart, DateTime dataEnd, float value);
        bool DeletePret(string idPret);

    }
}
