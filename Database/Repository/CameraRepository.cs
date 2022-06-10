using System;
using System.Collections.Generic;
using booking.Database.Models;
using System.Text;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Npgsql;
using System.Threading.Tasks;

namespace booking.Database.Repository
{
    public class CameraRepository : RepositoryBase<Camera>, ICameraRepository
    {
        private readonly BookingContext _context;
        public CameraRepository(BookingContext context) : base(context)
        {
            _context = context;
        }

        public async Task AddCamera(string numeCamera, int capacitateCamera, int nrCamere)
        {
            var numeCameraParam = new NpgsqlParameter("nume_camera", numeCamera);
            var capacitateCameraParam = new NpgsqlParameter("capacitate_camera", capacitateCamera);
            var numarCamereParam = new NpgsqlParameter("numar_camere", nrCamere);
            var rows = await _context.Database.ExecuteSqlRawAsync($"CALL public.\"AddCamera\"('{numeCamera}',{capacitateCamera},{nrCamere})");
        }

        public async Task<bool> DeleteCamera(string numeCamera)
        {
            Camera resultUnique = GetRecords()
                .Where(u => u.Nume.Equals(numeCamera))
                .FirstOrDefault();
            if (resultUnique == null)
                return false;
            Delete(resultUnique);
            return true;
        
        }

       

        public List<Camera> GetCamere()
        {
            return GetRecords().Select(s => new Camera() { Id = s.Id, Nume = s.Nume, Capacitate = s.Capacitate, NrCamere = s.NrCamere}).ToList();
        }
    }
}
