using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace booking.Database.Models
{
    public class ServiciiOferta : BaseModel
    {
        public int IdServiciu { get; set; }
        public int IdOferta { get; set; }

        [ForeignKey("IdServiciu")]
        public Serviciu Serviciu { get; set; }

        [ForeignKey("IdOferta")]
        public Oferta Oferta { get; set; }
    }
}
