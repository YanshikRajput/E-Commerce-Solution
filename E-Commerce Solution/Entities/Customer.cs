using EE_Commerce_Solution.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Solution.Entities
{
    public class Customer
    {
        public int C_ID { get; set; }
        public string C_Name { get; set; }
        public string C_Password { get; set; }
        public string C_ShortCode {get; set; }

        public static List<Product> OrderDetail = new List<Product>();

        public static void ShowCart()
        {
            OrderDetail.ForEach((i) =>
            {
                Console.WriteLine($" Product ID :{i.P_ID} \n Product Name :{i.P_Name}\n Product Price :{i.P_Price}\n Product Quantity :{i.P_Quantity}\n Product Manufacturer :{i.P_Manufacturer}\n Product ShortCode : {i.P_ShortCode}");
            });
        }
    }
}
