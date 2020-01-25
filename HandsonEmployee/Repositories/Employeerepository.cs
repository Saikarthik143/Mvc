
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsonEmployee.Models;

namespace HandsonEmployee.Repositories
{
    public class EmployeeRepository
    {
        public static List<Employee> list = new List<Employee>()
        {
            new Employee(){ Name="Sai karthik",Eid="12Sk",Pwd="123" }
        };
        public EmployeeRepository()
        {

        }
        public void Add(Employee item)
        {
            list.Add(item);
        }
        public Employee Validate(string id, string pwd)
        {
            foreach (var item in list)
            {
                if (item.Eid == id && item.Pwd == pwd)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
