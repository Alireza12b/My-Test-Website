using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exception
{
    public class EmailAddressExistsException : DomainExeption
    {
        public override string Message => "This National Code Exists";
    }
}
