using booking.Database.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace booking.Database.Repository
{
    public interface ICameraRepository : IRepositoryBase<Camera>
    {
        Task AddCamera(string numeCamera, int capacitateCamera, int nrCamere);
        Task<bool> DeleteCamera(string numeCamera);
    }
}
