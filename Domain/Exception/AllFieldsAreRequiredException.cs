using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exception
{
    public class AllFieldsAreRequiredException : DomainExeption
    {
        public override string Message => "All fields are required";
    }
}
