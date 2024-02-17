using System;
using System.Linq;

namespace Zadacha01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine()
                 .Split().Select(int.Parse).ToArray();

            Console.WriteLine($"Min = {arr.Min()}");
            Console.WriteLine($"Max = {arr.Max()}");
            Console.WriteLine($"Sum = {arr.Sum()}");
            Console.WriteLine($"Average = {arr.Average()}");

            //int min = arr[0];
            //int max = arr[0];
            //int sum = 0;
            //double avg = 0.0;

            //foreach (var item in arr)
            //{
            //    if (item < min) min = item;
            //    if (item > max) max = item;
            //    sum += item;
            //}
            //avg = 1.0 * sum / arr.Length;

            //Console.WriteLine($"Min = {min}");
            //Console.WriteLine($"Max = {max}");
            //Console.WriteLine($"Sum = {sum}");
            //Console.WriteLine($"Average = {avg}");
        }
    }
}
