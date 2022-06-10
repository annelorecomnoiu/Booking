using booking.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace booking.Database.Repository
{
    public class DotareRepository : RepositoryBase<Dotare>, IDotareRepository
    {
        public DotareRepository(BookingContext context) : base(context)
        {

        }
        public bool AddDotare(string numeDotare)
        {
            var resultUnique = GetRecords().Any(u => u.Nume.Equals(numeDotare));
            if (resultUnique != false)
                return false;
            Insert(new Dotare(numeDotare));
            return true;
        }

        public bool DeleteDotare(string numeDotare)
        {
            Dotare resultUnique = GetRecords()
                .Where(u => u.Nume.Equals(numeDotare))
                .FirstOrDefault();
            if (resultUnique == null)
                return false;
            Delete(resultUnique);
            return true;
        }

        public List<Dotare> GetDotari()
        {
            return GetRecords().Select(s => new Dotare() { Nume = s.Nume, Id = s.Id }).ToList();
        }
    }
}
