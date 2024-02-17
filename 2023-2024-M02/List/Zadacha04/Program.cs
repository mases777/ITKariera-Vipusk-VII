using System;
using System.Linq;

namespace Zadacha04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split().Select(int.Parse).ToList();
            var bombPower = Console.ReadLine()
                .Split().Select(int.Parse).ToArray();
            int bomb = bombPower[0];
            int power = bombPower[1];
            while (numbers.Contains(bomb))
            {
                int area = numbers.IndexOf(bomb);
                if (area - power < 0 && area + power >= numbers.Count)
                {
                    numbers.Clear(); break;
                }
                for (int i = area - power; i <= area + power; i++)
                {
                    if (i < 0) continue;
                    if (area - power >= numbers.Count) break;
                    numbers.RemoveAt(area - power);
                }
            }
            int sum = 0;
            foreach (var item in numbers) sum += item;
            Console.WriteLine(sum);

        }
    }
}
