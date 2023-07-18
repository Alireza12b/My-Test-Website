using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exception
{
    public class PasswordIsWeakException : DomainExeption
    {
        public override string Message => "Password is weak ";
    }
}
