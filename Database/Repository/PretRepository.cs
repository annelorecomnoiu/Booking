using booking.Database.Models;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace booking.Database.Repository
{
    public class PretRepository : RepositoryBase<Pret>, IPretRepository
    {
        private readonly BookingContext _context;
        public PretRepository(BookingContext context) : base(context)
        {
            _context = context;
        }
        public async Task AddPretAsync(Camera camera, DateTime dataStart, DateTime dataEnd, float value)
        {
            string dataStartString = dataStart.ToString("dd-MM-yyyy");
            string dataEndString = dataEnd.ToString("dd-MM-yyyy");
            var rows = await _context.Database.ExecuteSqlRawAsync($"CALL public.\"AddPret\"({camera.Id},'{dataStartString}','{dataEndString}',{value})");
        }

        public bool DeletePret(string idPret)
        {
            Pret pretDeSters = GetById(Int32.Parse(idPret));
            Delete(pretDeSters);
            return true;
        }
        public List<Pret> GetPreturi()
        {
            return GetRecords().Select(s => new Pret() { Valoare = s.Valoare, DataStart = s.DataStart, DataEnd = s.DataEnd, IdCamera = s.IdCamera }).ToList();
        }
    }
}
