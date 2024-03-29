﻿using System;

namespace Zadacha01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine(Dec2Bin(n));
            Console.WriteLine(Dec2Hex(n));

            var b = Console.ReadLine();
            Console.WriteLine(Bin2Dec(b));
        }

        static int Bin2Dec(string b)
        {
            int result = 0;
            int pow = 0;
            for (int i = b.Length - 1; i >= 0; i--)
            {
                var a = int.Parse(b[i].ToString());
                result += (int)(a * Math.Pow(2, pow));
                pow++;
            }
            return result;
        }

        static string Dec2Hex(int n)
        {
            string result = "";
            while (n > 0)
            {
                int hex = (n % 16) + 48;
                if (hex > 57) hex += 7;
                result += (char)hex;
                n = n / 16;
            }
            return StringReverse(result);
        }

        static string Dec2Bin(int n)
        {
            string result = "";
            while (n > 0)
            {
                result += n % 2;
                n = n / 2;
            }
            return StringReverse(result);
        }

        static string StringReverse(string str)
        {
            string result = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                result += str[i];
            }
            return result;
        }
    }
}
