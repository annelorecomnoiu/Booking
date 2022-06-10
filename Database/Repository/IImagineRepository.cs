using booking.Database.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace booking.Database.Repository
{
    public interface IImagineRepository : IRepositoryBase<Imagine>
    {
        bool AddImagini(List<string> imagini, Camera camera);

    }
}
