using booking.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace booking.Database.Repository
{
    public class ImagineRepository : RepositoryBase<Imagine>, IImagineRepository
    {
        private readonly BookingContext _context;
        public ImagineRepository(BookingContext context) : base(context)
        {
            _context = context;
        }

        public bool AddImagini(List<string> imagini, Camera camera)
        {
            foreach (var imagine in imagini)
            {
                Insert(new Imagine()
                { Camera = camera, IdCamera = camera.Id, Path = imagine });
            }
            return true;
        }

        public List<Imagine> GetImagine()
        {
            return GetRecords().Select(s => new Imagine() { IdCamera = s.IdCamera, Path = s.Path }).ToList();
        }
    }
}
