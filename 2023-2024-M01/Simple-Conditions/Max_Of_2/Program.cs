using System;

namespace Max_Of_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n1 = int.Parse(Console.ReadLine());
            var n2 = int.Parse(Console.ReadLine());
            if (n1 > n2)
            {
                Console.WriteLine(n1);
            }
            else
            {
                Console.WriteLine(n2);
            }


        }
    }
}
