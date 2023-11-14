using System;

namespace Excellent_Result
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            if (n >= 5.50)
            {
                Console.WriteLine("Excellent!");
            }
            else
            {
                Console.WriteLine("Not excellent.");
            }

        }
    }
}
