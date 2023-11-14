using System;

namespace BonusPoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            double bonus = 0;
            if (n <= 100)
            {
                bonus += 5.0;
            }
            else if (n <= 1000)
            {
                bonus += n / 5.0;
            }
            else
            {
                bonus += n / 10.0;
            }
            if (n % 2 == 0)
            {
                bonus++;
            }
            if (n % 10 == 5)
            {
                bonus += 2;
            }
            Console.WriteLine(bonus);
            Console.WriteLine(n + bonus);

        }
    }
}
