using System;
using System.Linq;

namespace add1core
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = 4, height = 5;
            int offsetX = 0, offsetY = 0;
            BuildSquare(width, height);
            UserControl(width, height, ref offsetX, ref offsetY);
            Console.ReadKey();
        }
        static void UserControl(int width, int height, ref int offsetX, ref int offsetY)
        {
            ConsoleKey key;
            do
            {
                key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.W:
                    case ConsoleKey.UpArrow:
                        break;
                    case ConsoleKey.A:
                    case ConsoleKey.LeftArrow:
                        break;
                    case ConsoleKey.S:
                    case ConsoleKey.DownArrow:
                        ShiftSquare(width, height, ref offsetX, ref offsetY);
                        break;
                    case ConsoleKey.D:
                    case ConsoleKey.RightArrow:
                        break;
                    default:
                        Console.WriteLine("Wrong key!");
                        break;
                }
            } while (key != ConsoleKey.Escape);
        }

        static void BuildSquare(int width, int height)
        {
            string line = String.Concat(Enumerable.Repeat("*", width));
            string square = String.Concat(Enumerable.Repeat(line + "\n", height));
            Console.WriteLine(square);
            string str;
            Console.WriteLine();
        }
        
        static void ShiftSquare(int width, int height, ref int offsetX, ref int offsetY)
        {
            Console.SetCursorPosition(0,offsetY);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0,offsetY+height);
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", width)));
            offsetY++;
            for (int i = 0; i < 9; i++)
            {
                
            }
        }
    }
}