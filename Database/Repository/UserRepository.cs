using booking.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace booking.Database.Repository
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(BookingContext context) : base(context)
        {

        }
        public bool Login(string username, string password)
        {
            var result = GetRecords().Any(u => u.Username.Equals(username) && u.Password.Equals(password));
            return result;
        }

        public bool Register(string username, string password, string rol)
        {
            var resultUnique = GetRecords().Any(u => u.Username.Equals(username));
            if (resultUnique != false)
                return false;
            Insert(new User(username, password, rol));
            return true;
        }

        public int VerifyRole(string username)
        {
            var result = GetRecords()
                .Where(u => u.Username.Equals(username))
                .FirstOrDefault();
            switch (result.Rol)
            {
                case "Administrator":
                    return 0;
                case "Angajat":
                    return 1;
                case "Utilizator":
                    return 2;
                default:
                    return 3;
            }
        }
    }
}
