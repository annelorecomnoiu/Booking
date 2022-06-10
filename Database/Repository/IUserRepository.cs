using booking.Database.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace booking.Database.Repository
{
    public interface IUserRepository : IRepositoryBase<User>
    {
        bool Login(string username, string password);
        bool Register(string username, string password, string rol);
    }
}
