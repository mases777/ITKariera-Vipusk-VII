using System;

namespace Zadacha03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nights = int.Parse(Console.ReadLine());
            string destination = Console.ReadLine();
            string roomType = Console.ReadLine();

            double pricePerNight = 0;

            switch (destination)
            {
                case "Maldives":
                    if (roomType == "beach villa") pricePerNight = 380;
                    else if (roomType == "apartment") pricePerNight = 450;
                    break;
                case "Bora Bora":
                    if (roomType == "beach villa") pricePerNight = 350;
                    else if (roomType == "apartment") pricePerNight = 420;
                    break;
                case "Singapore":
                    if (roomType == "beach villa") pricePerNight = 390;
                    else if (roomType == "apartment") pricePerNight = 490;
                    break;
            }

            double totalCost = nights * pricePerNight;

            Console.WriteLine($"They have to spend {totalCost:f2} leva.");
        }
    }
}
