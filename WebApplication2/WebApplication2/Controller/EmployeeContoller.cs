﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using EmployeeManagement.Model;
namespace EmployeeManagement.Controllers
{
    public class EmployeeController : Controller
    {
        //  IEmployeeRepository employeeRepository = new EmployeeRepository();
        private readonly IEmployeeRepository employeeRepository;
        public EmployeeController(IEmployeeRepository emrepository)//dependency injected object
        {
            employeeRepository = emrepository;
        }
        public IActionResult Search(int? id)
        {
            int Id = (int)((id == null) ? 1 : id);

            Employee emp = employeeRepository.GetEmployee(Id);
            //if (emp != null)
            //{
            //    return Content(emp.Id + "\n" + emp.Name + "\n" + emp.Email + "\n " + emp.Dept);
            //}
            //else
            //    return Content("Employee does not exist");
            return View(emp);
        }
        public IActionResult Index()
        {
            List<Employee> elist = employeeRepository.Display();
            return View(elist);
        }

        public ViewResult AboutEmployee()
        {
            Employee emp = employeeRepository.GetEmployee(2);
            //ViewBag.projectName = "BlackPanter";
            EmployeeProjectViewModel ep = new EmployeeProjectViewModel();
            ep.employee = emp;
            ep.projectname = "BlackPanter";
            return View(ep);
        }
        public IActionResult GetAllEmployees()
        {
            List<Employee> elist = employeeRepository.Display().Where(e => e.Dept==Dept.Accounts).ToList();
            //absolute path to refer a view
            return View("Index", elist);
        }
        
        public IActionResult Create()
        {
            //Employee emp = employeeRepository.GetEmployee(1);
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee emp)
        {
            if(ModelState.IsValid)
            {
                employeeRepository.AddEmployee(emp);
                return RedirectToAction("Index");
                
            }
            return View();
        }
      public IActionResult Fail()
        {
            return View();
        }
        public IActionResult Success()
        {
            return View();
        }
        public IActionResult List()
        {
            List<Employee> elist = employeeRepository.Display();
            return View(elist);
        }
        [HttpGet]

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(Employee employee)
        {
            bool res = employeeRepository.AddEmployee(employee);
            return RedirectToAction("Index");
        }
    }
}