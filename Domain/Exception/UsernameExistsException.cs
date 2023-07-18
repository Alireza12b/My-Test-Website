using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exception
{
    public class UsernameExistsException : DomainExeption
    {
        public override string Message => "This Username Exists";
    }
}
