using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace booking.Database.Models
{
    public class Imagine : BaseModel
    {
        [Required]
        public int IdCamera { get; set; }

        [ForeignKey("IdCamera")]
        public Camera Camera { get; set; }

        [Required]
        public string Path { get; set; }

        public Imagine() : base()
        {
        }

    }


}
