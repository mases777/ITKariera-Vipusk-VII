using System;

namespace Zadacha07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int container = 0;
            for (int i = 1; i <= n; i++)
            {
                int water = int.Parse(Console.ReadLine());
                container += water;
                if (container > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    container -= water;
                }
            }
            Console.WriteLine(container);
        }
    }
}
