using EE_Commerce_Solution.Entities;
using System;
using System.Collections.Generic;

namespace E_Commerce_Solution.Entities
{
    public class CustomerOperations
    {
        public static List<Customer> customers = new List<Customer>()
        {
            new Customer
            {
                C_ID=1,
                C_Name="Yanshik",
                C_Password ="1234"

            }
        };

        public static void CustomerLogin(int id, string pass)
        {
            customers.ForEach((i) =>
            {
                if (i.C_ID == id && i.C_Password == pass)
                {
                    CustomerMenu();
                }
                else
                {
                    Console.WriteLine("Id or Password Incorrect-Check Credentials and Try Again");
                }
            });
        }

        public static void CustomerMenu()
        {

            Console.WriteLine("Products List\n");
            ProductManagement.ListOfAllProducts();
            Console.WriteLine("\nPlease Select Option");
            Console.WriteLine("a. Add Product in Cart");
            Console.WriteLine("b. Search Products");
            Console.WriteLine("c. Exit!");

            char ch = Convert.ToChar(Console.ReadLine());

            switch (ch)
            {
                case 'a':
                    Console.WriteLine("Enter Id to be Add");
                    int id = Convert.ToInt32(Console.ReadLine());

                    AddProductToCart(id, 0);
                    break;
                case 'b':
                    SearchProduct();
                    break;
                case 'c':

                    Console.WriteLine("Exit");
                    break;

                default:
                    Console.WriteLine("Invalid Selection");
                    break;
            }

        }
        public static void AddProductToCart(int id, int totalPrice)
        {

            ProductManagement.productDetails.ForEach((i) =>
            {
                if (i.P_ID == id)
                {
                    Console.WriteLine("Enter Quantity");
                    int quantity = Convert.ToInt32(Console.ReadLine());

                    if (i.P_Quantity >= quantity)
                    {

                        i.P_Quantity = i.P_Quantity - quantity;
                        Customer.OrderDetail.Add(new Product
                        {
                            P_ID= i.P_ID,
                            P_Name= i.P_Name,
                            P_Price=i.P_Price,
                            P_Quantity=quantity,
                            P_Manufacturer=i.P_Manufacturer
                        });
                        totalPrice += (i.P_Price * quantity);
                        Console.WriteLine("Hurray!! Product added into your Cart ");
                        Console.WriteLine("Wanna Shop More then write yes else no");
                        var input = Console.ReadLine();
                        if (input == "yes")
                        {
                            Console.WriteLine("Add By Id");
                            int id = Convert.ToInt32(Console.ReadLine());
                            AddProductToCart(id, totalPrice);
                        }
                        else if (input == "no")
                        {
                            Customer.ShowCart();
                            Console.WriteLine("Total Price For Order :" + totalPrice);
                            CustomerMenu();
                        }


                    }
                    else
                    {
                        Console.WriteLine("Product Not Available");
                    }
                }

            });
            Console.WriteLine("To login as a Manager write yes or no");
            var input1 = Console.ReadLine();
            if (input1 == "yes")
            {
                Console.WriteLine("Enter Manager Id");
                int managerId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Password");
                var managerPass = Console.ReadLine();
                InventoryManagerOperations.ManagerLogin(managerId, managerPass);

            }
        }
        public static void SearchProduct()
        {
            ProductManagement.SearchProduct();
        }
    }
}
