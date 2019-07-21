using Enumeracao.Entities;
using System;
using Enumeracao.Entities.Enums;

namespace Enumeracao
{
    class Program
    {
        static void Main(string[] args)
        {

            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            //converte um tipo enum para um tipo string
            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);

            //converte um tipo string para um tipo enum
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);

            //converte um tipo inteiro para um tipo enum
            OrderStatus os1 = (OrderStatus)2;
            Console.WriteLine(os1);

            //converte um tipo enum para um tipo inteiro
            int n1 = (int)OrderStatus.Processing;
            Console.WriteLine(n1);

        }
    }
}
