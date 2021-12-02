using System;

namespace backpack
{
    class Program
    {
        static void Main(string[] args)
        {
            var backpack = new Backpack();
            var maxPriceItems = backpack.GetMaxPrices();
            Console.WriteLine($"Max item prices is: {maxPriceItems}");
        }
    }
}
