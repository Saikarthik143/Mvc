using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsonEmployee.Models;
using Microsoft.AspNetCore.Mvc;
using HandsonEmployee.Repositories;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HandsonEmployee.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Designation = new SelectList(new string[] { "Program Analysit", "Support", "Developer", "Testing", "Bench" });
            ViewBag.ProjectName = new SelectList(new string[] { "Emart", "Pictogram", "bo", "Banking", "Bench" });
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee item)
        {
            EmployeeRepository repository = new EmployeeRepository();
            repository.Add(item);
            return RedirectToAction("Login");
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string Eid, string pwd)
        {
           EmployeeRepository repository = new EmployeeRepository();

            Employee emp = repository.Validate(Eid, pwd);
            if (emp != null)
                return RedirectToAction("Details", emp);
            else
                ViewData["err"] = "invalid Credentials";
            return View();
        }
        public IActionResult Details(Employee Item)
        {
            return View(Item);
        }
    }
}