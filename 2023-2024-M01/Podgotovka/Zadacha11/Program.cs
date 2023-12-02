using System;

namespace Zadacha11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var paper = int.Parse(Console.ReadLine());
            var cloth = int.Parse(Console.ReadLine());
            var glue = double.Parse(Console.ReadLine());
            var percent = int.Parse(Console.ReadLine());

            var totalPaper = paper * 5.8;
            var totalCloth = cloth * 7.2;
            var totalGlue = glue * 1.2;
            var total = totalPaper + totalCloth + totalGlue;
            var price = total - total * percent / 100.0;

            Console.WriteLine($"{price:f3}");
        }
    }
}
