using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectDemo.Model
{
    public interface Sel
    {
         Seller GetSeller(int n);
        List<Seller> Display();
    }
}
