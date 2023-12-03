using System;

namespace Zadacha01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rent = int.Parse(Console.ReadLine());
            var food = rent * 3.0;
            var drinks = food * 0.8;
            var decorations = (food + drinks) * 0.1;
            var total = rent + food + drinks + decorations;
            Console.WriteLine($"{total:f2}");
        }
    }
}
