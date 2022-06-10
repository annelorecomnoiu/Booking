using System;
using System.Collections.Generic;

namespace booking.Database.Models
{
    public partial class User : BaseModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Rol { get; set; }

        public User(string username, string password, string rol)
        {
            Username = username;
            Password = password;
            Rol = rol;
        }
    }
}