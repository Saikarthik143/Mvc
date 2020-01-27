using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Model
{
    
    public class ValidationDomain:ValidationAttribute
    {
        private readonly string allowDomain;
        public ValidationDomain(string allowdomain)
        {
            this.allowDomain = allowdomain;
        }
        public override bool IsValid(object value)
        {
            string[] email = value.ToString().Split('@');
            if (email[1] == this.allowDomain)
                return true;
            else
                return false;
        }
    }
}
