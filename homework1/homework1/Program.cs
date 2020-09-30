using System;

namespace homework1
{
    internal class Program
    {
        public static void Main()
        {
            Task1();
            Task2();
            Task3();
            Task4();
        }

        public static void Task1()
        {
            int x = 10, y = 12, z = 3;
            x += y - x++ * z;
            Console.WriteLine(x);
            z = --x - y * 5;
            Console.WriteLine(z);
            y /= x + 5 % z;
            Console.WriteLine(y);
            z = x++ + y * 5;
            Console.WriteLine(z);
            x = y - x++ * z;
            Console.WriteLine(x);
        }

        public static void Task2()
        {
            #region Cut average

            {
                const int x = 5, y = 6, z = 2;
                const int sum = x + y + z;
                const int average = sum / 3;
                Console.WriteLine($"task2 sum: {sum}");
                Console.WriteLine($"task2 cut average: {average}");
            }

            #endregion

            #region Real average

            {
                const int x = 5, y = 6, z = 2;
                const int sum = x + y + z;
                const double average = (double) sum / 3;
                Console.WriteLine($"task2 sum: {sum}");
                Console.WriteLine($"task2 real average: {average}");
            }

            #endregion
        }

        public static void Task3()
        {
            const double pi = 3.14;
            double radius = 17;
            double square = pi * Math.Pow(radius, 2);
            Console.WriteLine($"task3: r = {radius}, S = {square}");
        }

        public static void Task4()
        {
            const double pi = 3.14;
            double radius = 3, height = 7;
            double volume = pi * Math.Pow(radius, 2) * height,
                square = 2 * pi * radius * (radius + height);
            Console.WriteLine($"task4: R = {radius}, h = {height}, V = {volume}, S = {square}");
        }
    }
}