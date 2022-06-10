using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace booking.Database.Models
{
    public class ServiciiRezervare : BaseModel
    {
        public int IdServiciu { get; set; }
        [ForeignKey("IdServiciu")]
        public Serviciu Serviciu { get; set; }

        public int IdRezervare { get; set; }
        [ForeignKey("IdRezervare")]
        public Rezervare Rezervare { get; set; }
    }
}
