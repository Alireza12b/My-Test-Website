using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exception
{
    public class EmailAddressNotValidException : DomainExeption
    {
        public override string Message => "Email Address is not valid";
    }
}
