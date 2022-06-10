using booking.Database.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace booking.Database.Repository
{
    public class OfertaRepository : RepositoryBase<Oferta>, IOfertaRepository
    {
        private readonly BookingContext _context;
        public OfertaRepository(BookingContext context) : base(context)
        {
            _context = context;
        }

        public async Task AddOferta(string numeOferta, float pretOferta, Camera camera, DateTime dataStart, DateTime dataEnd)
        {
            string dataStartString = dataStart.ToString("dd-MM-yyyy");
            string dataEndString = dataEnd.ToString("dd-MM-yyyy");
            var rows = await _context.Database.ExecuteSqlRawAsync($"CALL public.\"AddOferta\"('{numeOferta}',{pretOferta},{camera.Id},'{dataStartString}','{dataEndString}')");
        }

        public bool DeleteOferta(string numeOferta)
        {
            Oferta resultUnique = GetRecords()
                .Where(u => u.Nume.Equals(numeOferta))
                .FirstOrDefault();
            if (resultUnique == null)
                return false;
            Delete(resultUnique);
            return true;
        }

        public List<Oferta> GetOferte()
        {
            return GetRecords().Select(s => new Oferta()
            {
                Nume = s.Nume,
                Pret = s.Pret,
                DataEnd = s.DataEnd,
                DataStart = s.DataStart,
                IdCamera = s.IdCamera,
                Id = s.Id
            }).ToList();
        }
    }
}
