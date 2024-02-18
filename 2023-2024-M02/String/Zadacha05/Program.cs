using System;
using System.Linq;

namespace Zadacha05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var email = Console.ReadLine();

            var parts = email.Split('@').ToArray();
            var parts1 = parts[0];
            var parts2 = parts[1];

            int sum1 = 0, sum2 = 0;
            foreach (var item in parts1)
            {
                sum1 += (int)item;
            }
            foreach (var item in parts2)
            {
                sum2 += (int)item;
            }

            if (sum1 - sum2 >= 0)
            {
                Console.WriteLine("Call her!");
            }
            else
            {
                Console.WriteLine("She is not the one.");
            }
        }
    }
}
