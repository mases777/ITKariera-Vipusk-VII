using System;

namespace Convert_Rad_Deg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var radian = double.Parse(Console.ReadLine());
            var gradus = radian * 180 / Math.PI;
            Console.WriteLine(Math.Round(gradus));

        }
    }
}
