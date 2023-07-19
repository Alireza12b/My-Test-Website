using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Repository
{
    public interface IUserRepository
    {
        public bool IsExists(Predicate<User> predicate);
        public void Register(User user);
        public bool Login(string email, string password);
    }
}
