using System;

namespace hw6
{
    class Program
    {
        static void Main(string[] args)
        {
            const int
                a = 3,
                b = 3;
            Task2(a, b);
            Task3(a, b);
            Task4(5);
            Console.ReadKey();
        }

        static void Task2(int a, int b)
        {
            Console.WriteLine("Task 2: ");
            if (a > b)
            {
                int temp = a;
                a = b;
                b = temp;
            }

            int sum = 0;
            for (int i = a + 1; i < b; i++)
            {
                sum += i;
                if (i % 2 != 0)
                {
                    Console.Write($"{i} ");
                }
            }

            Console.WriteLine($"\nThe sum is: {sum}");
        }

        static void Task3(int width, int height)
        {
            Console.WriteLine("Task 3: ");
            BuildRectangle(width, height);
            BuildRightTriangle(height);
            BuildEquilateralTriangle(height);
            BuildRhombus(height);
        }

        static void BuildRectangle(int width, int height)
        {
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Console.Write("*");
                }

                Console.Write("\n");
            }
        }

        static void BuildRightTriangle(int height)
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }

                Console.Write("\n");
            }

            Console.WriteLine();
        }

        static void BuildEquilateralTriangle(int height)
        {
            for (int i = 0; i < height; i++)
            {
                string str = "";
                for (int j = 0; j < i * 2 + 1; j++)
                {
                    str += "*";
                }

                Console.Write(str.PadLeft(height + i));
                Console.Write("\n");
            }

            Console.WriteLine();
        }

        static void BuildRhombus(int height)
        {
            int additionalRows = (height * 2 - 1)/2;
            for (int i = additionalRows; Math.Abs(i) <= additionalRows; i--)
            {
                string str = "";
                for (int j = additionalRows-Math.Abs(i); Math.Abs(j) <= additionalRows-Math.Abs(i); j--)
                {
                    str += "*";
                }

                Console.Write(str.PadLeft(Math.Abs(i)+str.Length));
                Console.Write("\n");
            }

            Console.WriteLine();
        }



        static void Task4(int clientsCount)
        {
            Console.WriteLine("Task 4: ");
            int i = 1, f = 1;
            do
            {
                f = f * i;
                i++;
            } while (i<=clientsCount);

            Console.WriteLine(f);
        }
    }
}