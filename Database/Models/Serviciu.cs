using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace booking.Database.Models
{
    public class Serviciu : BaseModel
    {
        [Required]
        public string Nume { get; set; }
        [Required]
        public float Pret { get; set; }

        public Serviciu(string nume, float pret)
        {
            Nume = nume;
            Pret = pret;
        }
        public Serviciu()
        {

        }
    }
}
