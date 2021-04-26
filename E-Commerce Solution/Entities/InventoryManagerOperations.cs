using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Solution.Entities
{
    public class InventoryManagerOperations
    {
        public static List<InventoryManager> managers = new List<InventoryManager>()
        {
            new InventoryManager
            {
                InventoryManagerID=1,
                InventoryManagerName="Sam",
                InventoryManagerPassword ="qwerty"

            },
            new InventoryManager
            {
                InventoryManagerID=2,
                InventoryManagerName="Max",
                InventoryManagerPassword ="123456"

            }
        };
        public static void ManagerLogin(int id, string pass)
        {
            managers.ForEach((i) =>
            {
                if (i.InventoryManagerID == id && i.InventoryManagerPassword == pass)
                {
                    ManagerMenu();
                }
                else
                {
                    Console.WriteLine("Invalid Id or Wrong Password"); 
                }
            });
        }
        public static void ManagerMenu()
        {

            Console.WriteLine("Here are all Products\n");
            ProductManagement.ListOfAllProducts();
            Console.WriteLine("Please Select Option");
            Console.WriteLine("a. Add New Product");
            Console.WriteLine("b. Delete a Product");
            Console.WriteLine("c. Search a Product");
            Console.WriteLine("d. Update a Product");
            Console.WriteLine("e. Exit App!");

            char ch = Convert.ToChar(Console.ReadLine());

            switch (ch)
            {
                case 'a':
                    Console.WriteLine("Enter Id");
                    int id = -1;
                    bool flag = Int32.TryParse(Console.ReadLine(), out id);
                    while (!flag || id <= 0)
                    {

                        Console.WriteLine("Only Number Allowed and It can not be null/negative");
                        flag = Int32.TryParse(Console.ReadLine(), out id);

                    }
                    Console.WriteLine("Enter Product Name");
                    var ProductName = Console.ReadLine();
                    while (string.IsNullOrWhiteSpace(ProductName) || int.TryParse(ProductName, out _))
                    {
                        Console.WriteLine("Only Character Allowed and It can not be null");
                        ProductName = Console.ReadLine();

                    }
                    Console.WriteLine("Enter Price");
                    int price = -1;
                    bool flag1 = Int32.TryParse(Console.ReadLine(), out price);
                    while (!flag1 || price <= 0)
                    {

                        Console.WriteLine("Only Number Allowed and It can not be null/negative");
                        flag1 = Int32.TryParse(Console.ReadLine(), out price);

                    }
                    Console.WriteLine("Enter Manufacture Name");
                    var manufactureName = Console.ReadLine();
                    while (string.IsNullOrWhiteSpace(manufactureName) || int.TryParse(manufactureName, out _))
                    {
                        Console.WriteLine("Only Character Allowed and It can not be null");
                        manufactureName = Console.ReadLine();

                    }
                    Console.WriteLine("Enter Quantity");
                    int quantity = -1;
                    bool flag2 = Int32.TryParse(Console.ReadLine(), out quantity);
                    while (!flag2 || quantity <= 0)
                    {

                        Console.WriteLine("Only Number Allowed and It can not be null/negative");
                        flag2 = Int32.TryParse(Console.ReadLine(), out quantity);

                    }
                    ProductManagement.AddProduct(id, ProductName, price, quantity, manufactureName);

                    break;
                case 'b':
                    ProductManagement.DeleteProduct();
                    break;
                case 'c':
                    ProductManagement.SearchProduct();
                    break;
                case 'd':
                    Console.WriteLine("Enter Id");
                    int id1 = Convert.ToInt32(Console.ReadLine());
                    ProductManagement.UpdateProduct(id1);
                    break;
                case 'e':
                    Console.WriteLine("Exit");

                    break;

                default:
                    Console.WriteLine("Invalid Selection");
                    break;
            }

        }
    }
}
