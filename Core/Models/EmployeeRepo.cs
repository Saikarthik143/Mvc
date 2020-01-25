using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Models
{
    public class EmployeeRepo:IEmpRep

    {
        private List<Employee1> emplist;
        public EmployeeRepo()
        {
            emplist = new List<Employee1>() { new Employee1 (5, "Ajay"," @ssjc" ,"Insurance"),new  Employee1(2, "kajay"," @hnschs", "Insurance") } ;
        }
        public Employee1 GetEmployee(int id)
        {
            Employee1 e = emplist.FirstOrDefault(e => e.Id == id);
            return e;
        }
    }
}
