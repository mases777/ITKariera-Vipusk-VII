using System;

namespace Greeting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();

            //Console.WriteLine("Hello, {0}!", name);

            Console.WriteLine($"Hello, {name}!");

        }
    }
}
