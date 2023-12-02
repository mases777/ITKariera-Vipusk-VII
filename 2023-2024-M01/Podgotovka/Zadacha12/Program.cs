using System;

namespace Zadacha12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var foods = int.Parse(Console.ReadLine());
            var dear1 = double.Parse(Console.ReadLine());
            var dear2 = double.Parse(Console.ReadLine());
            var dear3 = double.Parse(Console.ReadLine());

            double neededFoods = days * (dear1 + dear2 + dear3);
            if (neededFoods <= foods)
            {
                Console.WriteLine($"{Math.Floor(foods - neededFoods)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(neededFoods - foods)} more kilos of food are needed.");
            }
        }
    }
}
