using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace booking.Database.Models
{
    public class Rezervare : BaseModel
    {
        public int NrCamere { get; set; }
        public DateTime DataStart { get; set; }
        public DateTime DataEnd { get; set; }

        public int IdCamera { get; set; }
        [ForeignKey("IdCamera")]
        public Camera Camera { get; set; }

        public int IdOferta { get; set; }
        [ForeignKey("IdOferta")]
        public Oferta Oferta { get; set; }

        public int IdUser { get; set; }
        [ForeignKey("IdUser")]
        public User User { get; set; }

        public Rezervare() : base()
        {
        }
    }
}