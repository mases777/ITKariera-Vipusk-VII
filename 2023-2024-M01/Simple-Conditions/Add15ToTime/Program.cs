using System;

namespace Add15ToTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var h = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());

            var minute = h * 60 + m + 15;
            h = minute / 60;
            m = minute - (h * 60);

            if (h > 23)
            {
                h = h - 24;
            }
            if (m < 10)
            {
                Console.WriteLine($"{h}:0{m}");
            }
            else
            {
                Console.WriteLine($"{h}:{m}");
            }

        }
    }
}
