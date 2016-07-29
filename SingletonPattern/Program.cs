using System;

namespace SingletonPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var product1 = SingletonProduct.Creat();
            var product2 = SingletonProduct.Creat();

            Console.WriteLine($"Product 1 size: {product1.GetSize()}");
            Console.WriteLine($"Product 2 size: {product2.GetSize()}");

            product1.ChangeSize(1);
            product2.ChangeSize(2);

            Console.WriteLine($"Product 1 size: {product1.GetSize()}");
            Console.WriteLine($"Product 2 size: {product2.GetSize()}");

            Console.ReadKey();
        }
    }
}