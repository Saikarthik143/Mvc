using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HandsOnMVCModelValidation.Repositories;
using HandsOnMVCModelValidation.Models;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace HandsOnMVCModelValidation.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
       [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Country = new SelectList(new string[] { "Select","india", "england", "new zeland","America","UK" });
            return View();
        }
       [HttpPost]
        public IActionResult Create(User item)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Login");
            }
            else
                return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string name,string pwd)
        {
            UserRepository repository = new UserRepository();
           
            User user = repository.Validate(name, pwd);
            if (user != null)
                return RedirectToAction("Details",user);
            else
                ViewData["err"] = "invalid Credentials";
               return View();
        }
        public IActionResult Details(User item)
        {
            return View(item);
        }
        public IActionResult Greet(int id)
        {
            return View();
        }
    }
}