using Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IUserServices
    {
        public void Register(UserRegisterDTO userRegisterDTO);
        public bool Login(string Email, string Password);
    }
}
