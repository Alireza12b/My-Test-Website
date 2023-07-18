using Domain;
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
        public bool IsExists(Predicate<User> predicate)
        {
            return DataBase.Users.Exists(predicate);
        }

        public void Register (User user)
        {
            DataBase.Users.Add(user);
        }

        public bool Login(string email, string password)
        {
            var validUser = DataBase.Users.FirstOrDefault(x => x.Email == email && x.Password == password);

            if (validUser != null)
                return true;
            
            return false;
        }
    }
}
