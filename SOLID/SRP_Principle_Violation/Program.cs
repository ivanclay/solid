using SRP_Priciple_Violation;
using System;

namespace SRP_Priciple_Violation
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();
            order.AddOrder();

            Console.ReadLine();
        }
    }
}
