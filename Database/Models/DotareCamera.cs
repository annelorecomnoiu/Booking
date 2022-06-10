using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace booking.Database.Models
{
    public class DotareCamera : BaseModel
    {
        public int IdCamera { get; set; }
        public int IdDotare { get; set; }

        [ForeignKey("IdCamera")]
        public Camera Camera { get; set; }

        [ForeignKey("IdDotare")]
        public Dotare Dotare { get; set; }

        public DotareCamera() { }

        public DotareCamera(int idCamera, int idDotare)
        {
            IdCamera = idCamera;
            IdDotare = idDotare;
        }
    }
}
