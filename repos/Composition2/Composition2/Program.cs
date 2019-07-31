using System;
using Composition2.Entities.Enums;
using Composition2.Entities;

namespace Composition2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data:");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter order data: ");
            Console.Write("Status:");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());
           
            for (int i = 1; i < n; n++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string nameProduct = Console.ReadLine();               

                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine());

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                //Product product = new Product(nameProduct, price);
                OrderItem item = new OrderItem(quantity, price, new Product(nameProduct, price));









            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");



        }
    }
}
