using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using Core.Models;



namespace Core.Controllers
{
    public class EmpCon:Controller
    {
        IEmpRep emprep;
        public EmpCon(IEmpRep emrepository)
        {
            emprep = emrepository;
        }
        private readonly IEmpRep empRep;
        public IActionResult Search(int? id)
        {
            int ID = (int)((id == null) ? 1 : id);
            Employee1 emp = emprep.GetEmployee(ID);
            if (emp != null)
            {
                return Content(emp.Id + "\n" + emp.Name + "\n" + emp.Dept);
            }
            return Content("employee does not exists");
            ViewData["id"] = emp.Id;
            ViewData["name"] = emp.Name;
            ViewData["dept"] = emp.Dept;
            ViewData["email"] = emp.Email;
            ViewBag.id = emp.Id;
            ViewBag.name = emp.Name;
            ViewBag.mail = emp.Email;
            ViewBag.dep = emp.Dept;

            return View();

        }
        public string Index()
        {
            return "hai hello";
        }
        public ViewResult Aboutus()
        {
            return View()
;        }
    }
}
