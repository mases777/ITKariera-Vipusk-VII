﻿using System;

namespace Zadacha02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string template = Console.ReadLine();

            while (true)
            {
                int counter = 0;
                while (text.Contains(template))
                {
                    text = text.Remove(text.IndexOf(template), template.Length);
                    counter++;
                }
                if (counter == 0)
                {
                    Console.WriteLine("No shake.");
                    break;
                }
                if (counter > 1)
                {
                    Console.WriteLine("Shake it.");
                }
                template = template.Remove(template.Length / 2, 1);
            }
            Console.WriteLine(text);
        }
    }
}
