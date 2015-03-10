using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLibrary
{
    public class BLL
    {
        public int? Cal(int? n1, int? n2)
        {
            int? n3 = n1 + n2;
            if (n3 == null) {return 0;}
            else { return n3; }
        }
    }
}
