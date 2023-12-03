using System;

namespace Zadacha05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            for (int d1 = 1; d1 <= 9; d1++)
                for (int d2 = 1; d2 <= 9; d2++)
                    for (int d3 = 1; d3 <= 9; d3++)
                    {
                        int sum = d1 + d2 + d3;
                        if (sum == n)
                            for (int d4 = 2; d4 <= 8; d4 += 2)
                                for (int d5 = 1; d5 <= 1; d5++)
                                {
                                    Console.Write($"{d1}{d2}{d3}{d4}{d5} ");
                                    count++;
                                }
                    }
            Console.WriteLine($"\nCount of winner numbers: {count}");
        }
    }
}
