using System;

namespace TrainingLab_Exam1_Problem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var h = double.Parse(Console.ReadLine()) * 100;
            var w = double.Parse(Console.ReadLine()) * 100;
                        
            int row = (int)h / 120;
            int col = ((int)w - 100) / 70;

            int seat = row * col - 3;

            Console.WriteLine(seat);
        }
    }
}
