using System;
using System.Linq;

namespace add1
{
    internal class Program
    {
        static int width = 3, height = 5;
        static private int[] offset = {0, 0};

        public static void Main(string[] args)
        {
            SquareBuild(width, height, offset);
            ActionSelector();
        }

        private static void SquareBuild(int width, int height, int[] offset)
        {
            string line = "".PadLeft(offset[0]) + String.Concat(Enumerable.Repeat("*", width));
            string fillLines = String.Concat(Enumerable.Repeat("\n", offset[1]));
            string str = fillLines+String.Concat(Enumerable.Repeat(line + "\n", height));
            Console.Clear();
            Console.WriteLine(str);
        }

        public static void ActionSelector()
        {
            ConsoleKey key;
            do
            {
                key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.W:
                    case ConsoleKey.UpArrow:
                        ChangeOffset(1,-1);
                        SquareBuild(width, height, offset);
                        break;
                    case ConsoleKey.A:
                        case ConsoleKey.LeftArrow:
                        ChangeOffset(0,-1);
                        SquareBuild(width,height,offset);
                        break;
                    case ConsoleKey.S:
                    case ConsoleKey.DownArrow:
                        ChangeOffset(1,1);
                        SquareBuild(width,height,offset);
                        break;
                    case ConsoleKey.D:
                    case ConsoleKey.RightArrow:
                        ChangeOffset(0,+1);
                        SquareBuild(width,height,offset);
                        break;
                    default:
                        Console.WriteLine($"Wrong key entered: {key}");
                        break;
                }
            } while (key != ConsoleKey.Escape);
        }

        private static void ChangeOffset(int i, int change)
        {
            if (offset[i] + change >= 0)
            {
                offset[i] += change;
            }
            else
            {
                offset[i] = 0;
            }
        }
    }
}