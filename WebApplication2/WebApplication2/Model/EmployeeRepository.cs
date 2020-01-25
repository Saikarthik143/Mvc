using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Model
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private List<Employee> employeeList;
        public EmployeeRepository()
        {
            employeeList = new List<Employee>() { new Employee(1,"Ajay","abc@gmail.com","cse"),
             new Employee(2,"karthik","abcd@gmail.com","cse"),
             new Employee(3,"Varma","abcde@gmail.com","cse"),};
        }
        public Employee GetEmployee(int id)
        {
            Employee e = employeeList.FirstOrDefault(e => e.Id == id);
            //foreach(Employee x in employeeList)
            //{
            //    if (x.Id == id)
            //        return x;
            //}
            return e;
        }
        public List<Employee> Display()
        {
            return employeeList;
        }
        public bool AddEmployee(Employee emp)
        {
            employeeList.Add(emp);
            return true;
        }
    }
}