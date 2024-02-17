using System;
using System.Linq;

namespace Zadacha05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split().Select(int.Parse).ToList();
            var counts = new int[numbers.Max() + 1];

            foreach (var item in numbers) counts[item]++;

            for (int i = 0; i < counts.Length; i++)
            {
                if (counts[i] > 0)
                {
                    Console.WriteLine($"{i} -> {counts[i]}");
                }
            }

        }
    }
}
