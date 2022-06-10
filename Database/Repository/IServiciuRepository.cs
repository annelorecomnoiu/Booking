using booking.Database.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace booking.Database.Repository
{
    public interface IServiciuRepository : IRepositoryBase<Serviciu>
    {
        bool AddServiciu(string numeServiciu, float pretServiciu);
        bool DeleteServiciu(string numeServiciu);
    }
}
