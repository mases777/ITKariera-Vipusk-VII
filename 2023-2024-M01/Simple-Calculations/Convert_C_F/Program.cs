using System;

namespace Convert_C_F
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var celsium = double.Parse(Console.ReadLine());
            var fahrenheit = celsium * 1.8 + 32;
            Console.WriteLine(fahrenheit);

        }
    }
}
