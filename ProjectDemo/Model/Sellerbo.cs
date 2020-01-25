using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectDemo.Model
{
    public class Sellerbo:Sel
    {
        private List<Seller> se;
        public Sellerbo()
        {
            se = new List<Seller>() { new Seller("karthik", "988", 1, "cts", "sriram"), new Seller("ajay", "635", 2, "tcs", "dwd") };
        }
        public Seller GetSeller(int n)
        {
            Seller s = se.FirstOrDefault(s => s.Id == n);
            return s;
        }
        public List<Seller> Display()
        {
            return se;
        }
    }
}
