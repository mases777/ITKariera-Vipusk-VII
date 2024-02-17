using System;

namespace Zadacha02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLower();

            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine($"{input[i]} -> {input[i] - 97}");
            }
        }
    }
}
