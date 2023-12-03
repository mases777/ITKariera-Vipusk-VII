using System;

namespace Zadacha02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tshirt = double.Parse(Console.ReadLine());
            var alltshirt = int.Parse(Console.ReadLine());
            var alljacket = int.Parse(Console.ReadLine());
            var alljeans = int.Parse(Console.ReadLine());
            var allshirt = int.Parse(Console.ReadLine());
            var money = double.Parse(Console.ReadLine());
            var jacket = tshirt * 1.4;
            var jeans = jacket * 0.8;
            var shirt = jeans - 10;
            var total = (tshirt * alltshirt) + (jacket * alljacket) + (jeans * alljeans) + (shirt * allshirt);
            if (money >= total)
            {
                Console.WriteLine($"Yes! {money - total:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"No! {total - money:f2} leva needed.");
            }
        }
    }
}
