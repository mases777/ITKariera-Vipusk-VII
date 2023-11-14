using System;

namespace Convert_USD_BGN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dolar = double.Parse(Console.ReadLine());
            var leva = dolar * 1.79549;

            //Console.WriteLine(Math.Round(leva, 2));

            Console.WriteLine($"{leva:f2} BGN");

        }
    }
}
