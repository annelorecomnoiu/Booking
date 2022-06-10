using booking.Database.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace booking.Database.Repository
{
    public interface IDotareRepository : IRepositoryBase<Dotare>
    {
        bool AddDotare(string numeDotare);
        bool DeleteDotare(string numeDotare);
    }
}
