using booking.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace booking.Database.Repository
{
    public class ServiciuRepository : RepositoryBase<Serviciu>, IServiciuRepository
    {
        public ServiciuRepository(BookingContext context) : base(context)
        {

        }
        public bool AddServiciu(string numeServiciu, float pretServiciu)
        {
            var resultUnique = GetRecords().Any(u => u.Nume.Equals(numeServiciu));
            if (resultUnique != false)
                return false;
            Insert(new Serviciu(numeServiciu, pretServiciu));
            return true;
        }

        public bool DeleteServiciu(string numeServiciu)
        {
            Serviciu resultUnique = GetRecords()
                .Where(u => u.Nume.Equals(numeServiciu))
                .FirstOrDefault();
            if (resultUnique == null)
                return false;
            Delete(resultUnique);
            return true;
        }

        public List<Serviciu> GetServicii()
        {
            return GetRecords().Select(s => new Serviciu() { Nume = s.Nume, Pret = s.Pret }).ToList();
        }
    }
}
