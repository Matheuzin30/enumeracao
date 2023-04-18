using System;
using System.Runtime.InteropServices;
using enumeracao.Entities;
using enumeracao.Entities.Enums;

namespace enumeracao
{
    class program
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

            string txt = OrderStatus.PendingPayment.ToString();

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(os); 

            Console.WriteLine(txt);
          
        }
    }
}