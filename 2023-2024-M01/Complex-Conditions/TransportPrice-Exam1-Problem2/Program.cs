using System;

namespace TransportPrice_Exam1_Problem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var dayOrNight = Console.ReadLine();
            double result = 0;

            if (n < 20)
            {
                if (dayOrNight == "day")
                    result = 0.7 + n * 0.79;
                else
                    result = 0.7 + n * 0.9;
            }
            else if (n < 100)
                result = n * 0.09;
            else
                result = n * 0.06;

            Console.WriteLine(result);
        }
    }
}
