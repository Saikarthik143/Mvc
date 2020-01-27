using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace EmployeeManagement.Model
{
    public class Employee
    {
       
        public int Id { get; set; }
        [Required]
        [MaxLength(10,ErrorMessage ="Length can be max 10")]
        public string Name { get; set; }
        [Required]
        [RegularExpression  (@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
         @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" + 
         @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",ErrorMessage ="invalid mail")]
        [DisplayName("Company Mail")]
        [ValidationDomain(allowdomain:"Cts.com")]

        public string Email { get; set; }

        public Dept Dept { get; set; }
        public Employee(int id, string name, string email, Dept dept)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.Dept = dept;
        }
        public Employee()
        {

        }
    }
}