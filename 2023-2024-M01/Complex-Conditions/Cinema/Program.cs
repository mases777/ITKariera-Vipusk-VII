using System;

namespace Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var project = Console.ReadLine();
            var row = int.Parse(Console.ReadLine());
            var col = int.Parse(Console.ReadLine());
            var result = 0.0;

            switch (project)
            {
                case "Premiere":
                    result = row * col * 12.0; break;
                case "Normal":
                    result = row * col * 7.5; break;
                case "Discount":
                    result = row * col * 5.0; break;
            }

            Console.WriteLine($"{result:f2} leva");

        }
    }
}
