using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectDemo.Model;
using Microsoft.AspNetCore.Mvc;
using System.Web;

namespace ProjectDemo.Controllers
{
    public class SelCon:Controller
    {
        ////Sel obj = new Sellerbo();
        private readonly Sel sellerrepository;
        public SelCon(Sel selrep)
        {
            sellerrepository = selrep;
        }
        public IActionResult Search(int? id)
        {
            int ID = (int)((id == null) ? 1 : id);
            Seller s = sellerrepository.GetSeller(ID);
            if (s != null)
            {
                return Content(s.Name + "\n" + s.Id + "\n" + s.Mobile + "\n" + s.Company + "\n" + s.Address);
            }
            else
                return Content("Seller is Not There ");
            //Seller ss = obj.GetSeller("1");
            //return ss.Name + "\n" + ss.Id + "\n" + ss.Mobile + "\n" + ss.Company + "\n" + ss.Address;
        }
        public IActionResult Dispaly()
        {
            return View();
        }
        public IActionResult Index()
        {
            List<Seller> slist = sellerrepository.Display();
            return View(slist);
        }
       
    }
}
