using System;

namespace Zadacha03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine()
                .Split(' ');
            string banWord = Console.ReadLine();
            
            foreach (var item in text)
            {
                if (banWord.Contains(item))
                {
                    banWord = banWord.Replace(item, new string('*', item.Length));
                }
            }
            Console.WriteLine(banWord);
        }
    }
}
