using System;
using System.Linq;

namespace add1
{
    internal class Program
    {
        private const int MaxSize = 10;

        public static void Main()
        {
            int width, height;
            int offsetX = 0, offsetY = 0;
            SetSizes(out width, out height);
            BuildSquare(width, height);
            RedrawSquare(width, height, offsetX, offsetY);
            UserControls(width, height, offsetX, offsetY);
        }

        private static void TempUse()
        {
            Console.CursorTop = 5;
            Console.WriteLine("Writing line");
        }

        private static void BuildSquare(int width, int height)
        {
            /*
             * Old drawing method:
            string line = "".PadLeft(offsetX) + String.Concat(Enumerable.Repeat("*", width));
            string fillLines = String.Concat(Enumerable.Repeat("\n", offsetY));
            string str = fillLines + String.Concat(Enumerable.Repeat(line + "\n", height));
            */
            string line = String.Concat(Enumerable.Repeat("*", width));
            string str = String.Concat(Enumerable.Repeat(line + "\n", height));
            Console.Clear();
            Console.WriteLine(str);
        }

        private static void RedrawSquare(int width, int height, int offsetX, int offsetY)
        {
            Console.SetCursorPosition(1, 1);
            Console.Write(String.Concat(Enumerable.Repeat("-",2)));
            Console.SetCursorPosition(1, 1);
            Console.Write(String.Concat(Enumerable.Repeat("+\n".PadLeft(2),2)));
        }

        public static void UserControls(int width, int height, int offsetX, int offsetY)
        {
            ConsoleKey key;
            do
            {
                key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.W:
                    case ConsoleKey.UpArrow:
                        ChangeOffset(ref offsetY, -1);
                        BuildSquare(width, height);
                        break;
                    case ConsoleKey.A:
                    case ConsoleKey.LeftArrow:
                        ChangeOffset(ref offsetX, -1);
                        BuildSquare(width, height);
                        break;
                    case ConsoleKey.S:
                    case ConsoleKey.DownArrow:
                        ChangeOffset(ref offsetY, 1);
                        BuildSquare(width, height);
                        break;
                    case ConsoleKey.D:
                    case ConsoleKey.RightArrow:
                        ChangeOffset(ref offsetX, +1);
                        BuildSquare(width, height);
                        break;
                    default:
                        Console.WriteLine($"Wrong key entered: {key}");
                        break;
                }
            } while (key != ConsoleKey.Escape);
        }

        private static void ChangeOffset(ref int offset, int change)
        {
            if (offset + change >= 0)
            {
                offset += change;
            }
            else
            {
                offset = 0;
            }
        }

        private static void SetSizes(out int width, out int height)
        {
            width = Convert.ToInt32(Console.ReadLine());
            height = Convert.ToInt32(Console.ReadLine());

            if (width > MaxSize) width = MaxSize;
            if (height > MaxSize) height = MaxSize;
        }
    }
}