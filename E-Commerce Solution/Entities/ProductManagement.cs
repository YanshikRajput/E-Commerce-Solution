using EE_Commerce_Solution.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Solution.Entities
{
    public class ProductManagement
    {
        public static List<Product> productDetails = new List<Product>()
        {
            new Product
            {
                P_ID=1,
                P_Name="BAT",
                P_Price=3500,
                P_Quantity=10,
                P_Manufacturer="SS",
                P_ShortCode = "CRKT"
            },
             new Product
            {
                 P_ID=2,
                P_Name="Ball",
                P_Price=500,
                P_Quantity=40,
                P_Manufacturer="SG",
                P_ShortCode = "CRCT",
            },
              new Product
            {
                P_ID=3,
                P_Name="Jeans",
                P_Price=1100,
                P_Quantity=35,
                P_Manufacturer="Roadster",
                P_ShortCode = "RDST"
            },
               new Product
            {
                 P_ID=4,
                P_Name="Shirt",
                P_Price=1300,
                P_Quantity=25,
                P_Manufacturer="H&M",
                P_ShortCode = "H&MM",
            }

        };
        public static void AddProduct(int id, string name, int price, int quantity, string manufacturer)
        {
            productDetails.Add(new Product
            {
                P_ID = id,
                P_Name = name,
                P_Price = price,
                P_Quantity = quantity,
                P_Manufacturer = manufacturer,
            });
        }

        public static void ListOfAllProducts()
        {

            productDetails.ForEach((i) =>
            {
                Console.WriteLine($" Product ID :{i.P_ID} \n Product Name :{i.P_Name}\n Product Price :{i.P_Price}\n Product Quantity :{i.P_Quantity}\n Product Manufacturer :{i.P_Manufacturer}\n Product ShortCode : {i.P_ShortCode}");
            });

        }
        public static void DeleteProduct()
        {
            ListOfAllProducts();
            Console.WriteLine("a. Delete By ID");
            Console.WriteLine("b. Delete By Name");
            Console.WriteLine("c. Manager Menu");
            char ch2 = Convert.ToChar(Console.ReadLine());
            switch (ch2)
            {
                case 'a':
                    Console.WriteLine("Enter Product Id to Delete The Product");
                    int a = Convert.ToInt32(Console.ReadLine());
                    DeleteById(a);
                    break;
                case 'b':
                    Console.WriteLine("Enter Product Name to Delete");
                    var sc = Console.ReadLine();
                    DeleteByName(sc);
                    break;
                case 'c':
                    InventoryManagerOperations.ManagerMenu();
                    break;

            }
        }
        public static void DeleteById(int id)
        {

            try
            {
                var data = productDetails.Single((i) => i.P_ID == id);
                productDetails.Remove(data);
                ListOfAllProducts();
            }
            catch
            {
                Console.WriteLine("Id not Found");
            }
        }
        public static void DeleteByName(string name)
        {
            try
            {
                var data = productDetails.Single((i) => i.P_Name == name);
                productDetails.Remove(data);
                ListOfAllProducts();
            }
            catch
            {
                Console.WriteLine("Name not Found");
            }
        }
        public static void SearchProduct()
        {
            Console.WriteLine("a. Search By ID");
            Console.WriteLine("b. Search By Name");
            Console.WriteLine("c. Search By Price");
            Console.WriteLine("d. Manager Menu");
            char ch3 = Convert.ToChar(Console.ReadLine());
            switch (ch3)
            {
                case 'a':
                    Console.WriteLine("Enter Id Number to Search");
                    int a = Convert.ToInt32(Console.ReadLine());
                    SearchByID(a);
                    break;
                case 'b':
                    Console.WriteLine("Enter Name of Product to Search");
                    var name = Console.ReadLine();
                    SearchByName(name);
                    break;
                case 'c':
                    Console.WriteLine("Enter Price of Product to Search");
                    SearchByPrice();
                    break;
                case 'd':
                    InventoryManagerOperations.ManagerMenu();
                    break;
                default:
                    Console.WriteLine("Invalid Selection");
                    break;
            }
        }
        public static void SearchByID(int Id)
        {
            var data = productDetails.FindAll((i) => i.P_ID == Id);
            if (data.Count > 0)
            {
                data.ForEach((i) =>
                {
                    Console.WriteLine($" Product ID :{i.P_ID} \n Product Name :{i.P_Name}\n Product Price :{i.P_Price}\n Product Quantity :{i.P_Quantity}\n Product Manufacturer :{i.P_Manufacturer}\n Product ShortCode: {i.P_ShortCode}");

                });
            }
            else
            {
                Console.WriteLine("Id Not Found");
            }
        }
        public static void SearchByName(string name)
        {
            var data = productDetails.FindAll((i) => i.P_Name == name);
            if (data.Count > 0)
            {
                data.ForEach((i) =>
                {
                    Console.WriteLine($" Product ID :{i.P_ID} \n Product Name :{i.P_Name}\n Product Price :{i.P_Price}\n Product Quantity :{i.P_Quantity}\n Product Manufacturer :{i.P_Manufacturer} \n Product ShortCode: {i.P_ShortCode}");
                });
            }
            else
            {
                Console.WriteLine("Name Not Found");
            }
        }
        public static void SearchByPrice()
        {
            Console.WriteLine("a. Search By Equal Price");
            Console.WriteLine("b. Search By Greater Price");
            Console.WriteLine("c. Search By Lesser Price");
            char ch = Convert.ToChar(Console.ReadLine());
            switch (ch)
            {
                case 'a':
                    Console.WriteLine("Enter Price for Equal Search");
                    int price = Convert.ToInt32(Console.ReadLine());
                    EqualPrice(price);
                    break;
                case 'b':
                    Console.WriteLine("Enter Price for Greater Search");
                    int greaterPrice = Convert.ToInt32(Console.ReadLine());
                    GraterPrice(greaterPrice);
                    break;
                case 'c':
                    Console.WriteLine("Enter Price for lesser Search");
                    int lesserPricerice = Convert.ToInt32(Console.ReadLine());
                    LesserPrice(lesserPricerice);
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;

            }
        }
        public static void EqualPrice(int price)
        {
            var data = productDetails.FindAll((i) => i.P_Price == price);
            if (data.Count > 0)
            {
                data.ForEach((i) =>
                {
                    Console.WriteLine($" Product ID :{i.P_ID} \n Product Name :{i.P_Name}\n Product Price :{i.P_Price}\n Product Quantity :{i.P_Quantity}\n Product Manufacturer :{i.P_Manufacturer} \n Product ShortCode: {i.P_ShortCode}");
                });
            }
            else
            {
                Console.WriteLine("Price not Found");
            }

        }
        public static void GraterPrice(int price)
        {
            var data = productDetails.FindAll((i) => i.P_Price > price);
            if (data.Count > 0)
            {
                data.ForEach((i) =>
                {
                    Console.WriteLine($" Product ID :{i.P_ID} \n Product Name :{i.P_Name}\n Product Price :{i.P_Price}\n Product Quantity :{i.P_Quantity}\n Product Manufacturer :{i.P_Manufacturer}\n Product ShortCode: {i.P_ShortCode}");
                });
            }
            else
            {
                Console.WriteLine("Price not Found");
            }

        }
        public static void LesserPrice(int price)
        {
            var data = productDetails.FindAll((i) => i.P_Price < price);
            if (data.Count > 0)
            {
                data.ForEach((i) =>
                {
                    Console.WriteLine($" Product ID :{i.P_ID} \n Product Name :{i.P_Name}\n Product Price :{i.P_Price}\n Product Quantity :{i.P_Quantity}\n Product Manufacturer :{i.P_Manufacturer}\n Product ShortCode: {i.P_ShortCode}");
                });
            }
            else
            {
                Console.WriteLine("Price not Found");
            }

        }
        public static void UpdateProduct(int id)
        {
            try
            {
                var data = productDetails.Find((i) => i.P_ID == id);
                Console.WriteLine("Select an option to update");
                Console.WriteLine("a. Update Product Name ");
                Console.WriteLine("b. Update Product Price");
                Console.WriteLine("c. Update Product Quantity");
                Console.WriteLine("d. Manager Menu");
                char ch = Convert.ToChar(Console.ReadLine());
                switch (ch)
                {
                    case 'a':
                        Console.WriteLine("Enter Updated Product Name");
                        var newName = Console.ReadLine();
                        data.P_Name = newName;
                        ListOfAllProducts();
                        InventoryManagerOperations.ManagerMenu();
                        break;
                    case 'b':
                        Console.WriteLine("Enter updated Price");
                        int price = Convert.ToInt32(Console.ReadLine());
                        data.P_Price = price;
                        ListOfAllProducts();
                        InventoryManagerOperations.ManagerMenu();
                        break;
                    case 'c':
                        Console.WriteLine("Enter updated Quantity");
                        int quantity = Convert.ToInt32(Console.ReadLine());
                        data.P_Quantity = quantity;
                        ListOfAllProducts();
                        InventoryManagerOperations.ManagerMenu();
                        break;
                    case 'd':
                        InventoryManagerOperations.ManagerMenu();
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }

            }
            catch
            {
                Console.WriteLine("Product Not Found");
                InventoryManagerOperations.ManagerMenu();
            }
            Console.WriteLine("To login as a Customer Enter yes or no");
            var input1 = Console.ReadLine();
            if (input1 == "yes")
            {
                Console.WriteLine("Enter Manager Id");
                int CustomerId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Password");
                var CustomerPass = Console.ReadLine();
                CustomerOperations.CustomerLogin(CustomerId, CustomerPass);

            }

        }
    }
}
