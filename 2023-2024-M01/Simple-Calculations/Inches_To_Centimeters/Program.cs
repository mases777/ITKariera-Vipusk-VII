using System;

namespace Inches_To_Centimeters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inches = double.Parse(Console.ReadLine());
            var centimeters = inches * 2.54;
            Console.WriteLine(centimeters);


        }
    }
}
