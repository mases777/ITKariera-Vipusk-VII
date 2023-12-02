using System;

namespace Zadacha14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());

            while (m % 6 != 0)
            {
                m--;
            }
            for (int i = m; i >= n; i -= 6)
            {
                if (i == s)
                {
                    break;
                }
                Console.Write($"{i} ");
            }
        }
    }
}
