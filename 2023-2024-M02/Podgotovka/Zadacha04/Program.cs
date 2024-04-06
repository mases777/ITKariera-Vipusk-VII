using System;
using System.Collections.Generic;
using System.Linq;

namespace Zadacha04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var playerStats = new Dictionary<string, int>();
            char[] splitOn = new char[] { ' ', '-' };
            string input;
            while ((input = Console.ReadLine()) != "End of match")
            {
                var info = input
                    .Split(splitOn, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string player = info[0];
                int passes = int.Parse(info[1]);

                if (playerStats.ContainsKey(player))
                    playerStats[player] += passes;
                else playerStats[player] = passes;
            }
            foreach (var item in playerStats.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} has passed {item.Value} passes.");
            }
        }
    }
}
