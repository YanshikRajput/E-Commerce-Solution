using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EE_Commerce_Solution.Entities
{
    public class Product
    {
        public int P_ID { get; set; }
        public string P_Name { get; set; }
        public int P_Price { get; set; }
        public int P_Quantity { get; set; }
        public string P_Manufacturer { get; set; }
        public string P_ShortCode { get; set; }

    }

}
