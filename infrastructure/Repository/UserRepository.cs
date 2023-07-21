using Domain.Entities;
using Domain.Repository;
using Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrastructure.Repository
{
    public class UserRepository : IUserRepository
    {
        private WebsiteDbContext _database;
        public UserRepository(WebsiteDbContext dataBase)
        {
            _database = dataBase;
        }
        public bool IsExists(Predicate<User> predicate)
        {
            return _database.Users.Any(u => predicate(u));
        }

        public void Register (User user)
        {
            _database.Users.Add(user);
        }

        public bool Login(string email, string password)
        {
            var validUser = _database.Users.FirstOrDefault(x => x.Email == email && x.Password == password);

            if (validUser != null)
                return true;
            
            return false;
        }
    }
}
