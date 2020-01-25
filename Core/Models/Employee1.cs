using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Employee1
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Dept { get; set; }
        public Employee1(int id,string name,string mail,string dept)
        {
            this.Id = id;
            this.Name = name;
            this.Dept = dept;
            this.Email = mail;
        }
    }
}
