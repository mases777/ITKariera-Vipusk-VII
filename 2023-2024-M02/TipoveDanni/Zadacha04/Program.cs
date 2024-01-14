using System;

namespace Zadacha04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double meters = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            double s = double.Parse(Console.ReadLine());

            double time = h * 3600.0 + m * 60.0 + s;

            Console.WriteLine(Math.Round(meters / time, 6));
            Console.WriteLine(Math.Round((meters/1000.0) / (time / 3600.0), 6));
            Console.WriteLine(Math.Round((meters / 1609.0) / (time / 3600.0), 6));
        }
    }
}
