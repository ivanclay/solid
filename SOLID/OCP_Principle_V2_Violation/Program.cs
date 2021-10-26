using System;

namespace OCP_Principle_V2_Violation
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();

            var commonConsumerOrderValue =
               order.OrderDiscount(1000, ConsumerType.Common);

            var associateConsumerOrderValue =
                order.OrderDiscount(1000, ConsumerType.Associate);

            var specialConsumerOrderValue =
                order.OrderDiscount(1000, ConsumerType.Special);

            Console.WriteLine("OCP Principle - Violation");

            Console.WriteLine($"Common Consumer = " +
                $"{commonConsumerOrderValue}");

            Console.WriteLine($"Associate Consumer = " +
                $"{associateConsumerOrderValue}");

            Console.WriteLine($"Special Consumer = " +
                $" {specialConsumerOrderValue}");

            Console.ReadLine();
        }
    }
}
