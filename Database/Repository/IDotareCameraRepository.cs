using booking.Database.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace booking.Database.Repository
{
    public interface IDotareCameraRepository : IRepositoryBase<DotareCamera>
    {
        bool AddDotari(List<Dotare> dotari, Camera camera);
    }
}
