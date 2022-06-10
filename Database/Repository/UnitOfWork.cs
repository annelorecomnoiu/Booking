using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace booking.Database.Repository
{
    public class UnitOfWork
    {
        private readonly DbContext _efDbContext;

        public UnitOfWork
        (
            BookingContext efDbContext)
        {
            _efDbContext = efDbContext;

        }

        public async Task<bool> SaveChangesAsync()
        {
            try
            {
                var savedChanges = await _efDbContext.SaveChangesAsync();
                return savedChanges > 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
