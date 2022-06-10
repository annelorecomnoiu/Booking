using System;
using System.Collections.Generic;
using booking.Database.Models;
using System.Text;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace booking.Database.Repository
{
    public class DotareCameraRepository : RepositoryBase<DotareCamera>, IDotareCameraRepository
    {
        public DotareCameraRepository(BookingContext context) : base(context)
        {

        }

        public bool AddDotari(List<Dotare> dotari, Camera camera)
        {
            foreach (var dotare in dotari)
            {
                Insert(new DotareCamera()
                { Camera = camera, Dotare = dotare, IdCamera = camera.Id, IdDotare = dotare.Id });
            }
            return true;
        }

        public List<DotareCamera> GetDotareCamera()
        {
            return GetRecords().Select(s => new DotareCamera() { IdCamera = s.IdCamera, IdDotare = s.IdDotare }).ToList();
        }
    }
}
