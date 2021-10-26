using System;

namespace OCP_Principle_Violation
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product(
                1,
                "Pen",
                "Pen Blue",
                2.00M,
                3.40M,
                100,
                true
                );

            Console.WriteLine($"Product = {product.Name} Profit = {product.ProfitMargin()}");

            Console.ReadLine();
        }
    }
}
