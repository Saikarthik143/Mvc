using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectDemo.Model
{
    public class Seller
    {
        //string name;
        //string id;
        //string company;
        //string mobile;
        //string address;

        public string Name { get; set; }
        public int Id { get; set ; }
        public string Company { get ; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public Seller(string N, string mob, int Id,string Com,string add)
        {
            this.Name = N;
            this.Address = add;
            this.Mobile = mob;
            this.Id = Id;
            this.Company = Com;
        }
    }
}
