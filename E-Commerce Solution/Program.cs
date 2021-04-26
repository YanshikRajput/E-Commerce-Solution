using System;

namespace E_Commerce_Solution.Entities
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n------------------------------------------------ECommerceSolution-------------------------------------------------------\n");
            Console.WriteLine("Select Option for User Authentication");
            Console.WriteLine("a. Login as a Customer");
            Console.WriteLine("b. Login as an InventoryManager");
            Console.WriteLine("c. Exit App!");

            char ch = Convert.ToChar(Console.ReadLine());

            switch (ch)
            {
                case 'a':
                    Console.WriteLine("Enter Customer Id");
                    int CustomerId = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Password");
                    var CustomerPass = Console.ReadLine();
                    CustomerOperations.CustomerLogin(CustomerId, CustomerPass);
                    break;
                case 'b':
                    Console.WriteLine("Enter InventoryManager Id");
                    int InventorymanagerId = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Password");
                    var InventorymanagerPass = Console.ReadLine();
                    InventoryManagerOperations.ManagerLogin(InventorymanagerId, InventorymanagerPass);
                    break;
                case 'c':
                    Console.WriteLine("Exit");

                    break;

                default:
                    Console.WriteLine("Please Choose Valid Options");
                    break;
            }

        }

    }




}
