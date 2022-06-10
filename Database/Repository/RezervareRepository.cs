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
    public class RezervareRepository : RepositoryBase<Rezervare>, IRezervareRepository
    {
        private readonly BookingContext _context;
        public RezervareRepository(BookingContext context) : base(context)
        {
            _context = context;
        }

        public async Task AddRezervare(int idUser, int idCamera, int idOferta, int nrCamere, DateTime dataStart, DateTime dataEnd)
        {
            var idUserParam = new NpgsqlParameter("id_user", idUser);
            var idCameraParam = new NpgsqlParameter("id_camera", idCamera);
            var idOfertaParam = new NpgsqlParameter("id_oferta", idOferta);
            var numarCamereParam = new NpgsqlParameter("numar_camere", nrCamere);
            string dataStartString = dataStart.ToString("dd-MM-yyyy");
            string dataEndString = dataEnd.ToString("dd-MM-yyyy");
            var rows = await _context.Database.ExecuteSqlRawAsync($"CALL public.\"AddRezervare\"( {idUser}, {idCamera}, {idOferta}, {nrCamere}, '{dataStartString}', '{dataEndString}' )");
        }

        //public bool DeleteRezervare(string numeDotare)
        //{
        //    Dotare resultUnique = GetRecords()
        //        .Where(u => u.Nume.Equals(numeDotare))
        //        .FirstOrDefault();
        //    if (resultUnique == null)
        //        return false;
        //    Delete(resultUnique);
        //    return true;
        //}

        public List<Rezervare> GetRezervari()
        {
            return GetRecords().Select(s => new Rezervare()
            {
                IdCamera = s.IdCamera,
                IdUser = s.IdUser,
                IdOferta = s.IdOferta,
                NrCamere = s.NrCamere,
                DataEnd = s.DataEnd,
                DataStart = s.DataStart
            }).ToList();
        }
    }
}