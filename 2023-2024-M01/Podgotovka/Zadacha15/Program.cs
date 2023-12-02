using System;

namespace Zadacha15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int a = number % 10;
            number = number / 10;
            int b = number % 10;
            number = number / 10;
            int c = number;

            for (int m = 1; m <= a; m++)
                for (int n = 1; n <= b; n++)
                    for (int p = 1; p <= c; p++)
                    {
                        Console.WriteLine($"{m} * {n} * {p} = {m * n * p}");
                    }
        }
    }
}
