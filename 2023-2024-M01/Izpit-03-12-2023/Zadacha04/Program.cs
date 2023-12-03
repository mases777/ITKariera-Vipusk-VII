using System;

namespace Zadacha04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int materialsCount = int.Parse(Console.ReadLine());

            int tilesCount = 0;
            int toolsCount = 0;
            int paintCount = 0;

            for (int i = 0; i < materialsCount; i++)
            {
                string materialType = Console.ReadLine();

                switch (materialType)
                {
                    case "tile":
                        tilesCount++;
                        break;
                    case "tools":
                        toolsCount++;
                        break;
                    case "paint":
                        paintCount++;
                        break;
                }
            }

            Console.WriteLine($"Tiles: {tilesCount}");
            Console.WriteLine($"Tools: {toolsCount}");
            Console.WriteLine($"Paint: {paintCount}");
        }
    }
}
