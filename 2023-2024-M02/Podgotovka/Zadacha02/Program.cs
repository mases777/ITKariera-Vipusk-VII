using System;
using System.Collections.Generic;
using System.Linq;

namespace Zadacha02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] splitOn = new char[] { ' ', ',' };
            var patients = Console.ReadLine()
                .Split(splitOn, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input;
            while ((input = Console.ReadLine()) != "END OF PATIENTS")
            {
                switch (input)
                {
                    case "Add patient":
                        AddVisitor(patients);
                        break;
                    case "Add patient on position":
                        AddVisitorOnPosition(patients);
                        break;
                    case "Remove patient on position":
                        RemoveVisitorOnPosition(patients);
                        break;
                    case "Remove last patient":
                        RemoveLastVisitor(patients);
                        break;
                    case "Remove first patient":
                        RemoveFirstVisitor(patients);
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", patients));
        }
        static void RemoveFirstVisitor(List<string> items)
        {
            items.RemoveAt(0);
        }

        static void RemoveLastVisitor(List<string> items)
        {
            items.RemoveAt(items.Count - 1);
        }

        static void RemoveVisitorOnPosition(List<string> items)
        {
            var position = int.Parse(Console.ReadLine());
            items.RemoveAt(position);
        }

        static void AddVisitorOnPosition(List<string> items)
        {
            string newItem = Console.ReadLine();
            var position = int.Parse(Console.ReadLine());
            items.Insert(position, newItem);
        }
        static void AddVisitor(List<string> items)
        {
            string newItem = Console.ReadLine();
            items.Add(newItem);
        }
    }
}
