using System;

namespace Zadacha13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var room = Console.ReadLine();
            var grade = Console.ReadLine();

            var result = 0.0;
            if (room == "room for one person")
                result = (days - 1) * 18.0;
            else if (room == "apartment")
            {
                result = (days - 1) * 25.0;
                if (days < 10) result = result * 0.7;
                else if (days <= 15) result = result * 0.65;
                else result = result * 0.5;
            }
            else
            {
                result = (days - 1) * 35.0;
                if (days < 10) result = result * 0.9;
                else if (days <= 15) result = result * 0.85;
                else result = result * 0.8;
            }
            if (grade == "positive")
                result = result * 1.25;
            else
                result = result * 0.9;
            Console.WriteLine($"{result:f2}");
        }
    }
}
