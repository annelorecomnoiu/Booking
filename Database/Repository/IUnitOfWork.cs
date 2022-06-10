using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace booking.Database.Repository
{
    interface IUnitOfWork
    {
        Task<bool> SaveChangesAsync();
    }
}