using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace booking.Database.Models
{
    public class Dotare : BaseModel
    {
        [Required]
        public string Nume { get; set; }
        public List<DotareCamera> Camere { get; set; } = new List<DotareCamera>();

        public Dotare() { }
        public Dotare(string nume)
        {
            Nume = nume;
        }

        public Dotare(string nume, int id)
        {
            Id = id;
            Nume = nume;
        }
    }
}
