using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace booking.Database.Models
{
    public class Camera : BaseModel
    {

        [Required]
        public string Nume { get; set; }

        [Required]
        public int Capacitate { get; set; }
       
        [Required]
        public int NrCamere { get; set; }

        public List<Pret> Preturi { get; set; } = new List<Pret>();
        public List<Imagine> Imagini { get; set; } = new List<Imagine>();
        public List<DotareCamera> Dotari { get; set; } = new List<DotareCamera>();

        public Camera() : base()
        {
        }

        
    }
}