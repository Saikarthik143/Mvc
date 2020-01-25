using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public string MyPage()
        {
            return "hello";
        }
        public ActionResult MyPage1()
        {
            return Json("{id:1,name:karthik}",JsonRequestBehavior.AllowGet);
        }
        public ActionResult MyPage6()
        {
            return View();
        }
        public ActionResult MyPage4()
        {
            return Json("{id:1,name:karthik}", JsonRequestBehavior.AllowGet);
        }
    }
}