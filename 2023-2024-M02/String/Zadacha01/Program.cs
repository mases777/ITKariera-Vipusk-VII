using System;
using System.Linq;

namespace Zadacha01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            Console.WriteLine(Palindrom(word));
        }

        static bool Palindrom(string word)
        {
            string reversed = new string(word.Reverse().ToArray());
            if (word.CompareTo(reversed) == 0)
            {
                return true;
            }
            return false;
        }
    }
}
