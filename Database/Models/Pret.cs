using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace booking.Database.Models
{
    public class Pret : BaseModel
    {
        public int IdCamera { get; set; }
        [ForeignKey("IdCamera")]

        public Camera Camera { get; set; }
        public DateTime DataStart { get; set; }
        public DateTime DataEnd { get; set; }
        public float Valoare { get; set; }

        public Pret() : base()
        {
        }
    }
}
