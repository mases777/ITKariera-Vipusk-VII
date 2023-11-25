using System;

namespace Zadacha03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nights = int.Parse(Console.ReadLine());
            var destination = Console.ReadLine();
            var typeRoom = Console.ReadLine();
            var total = 0.0;

            if (typeRoom == "double room")
            {
                if (destination == "Colorado")
                    total = nights * 38;
                else if (destination == "Alps")
                    total = nights * 35;
                else
                    total = nights * 39;
            }
            else
            {
                if (destination == "Colorado")
                    total = nights * 45;
                else if (destination == "Alps")
                    total = nights * 42;
                else
                    total = nights * 49;
            }
            Console.WriteLine($"They have to spend {total:f2} leva.");
        }
    }
}
