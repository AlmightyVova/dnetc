using System;

namespace hw5
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine(Task2(10));
            Console.WriteLine(Task2(-11));
            Console.WriteLine("".PadLeft(30, '-'));
            Task3();
            Console.WriteLine("".PadLeft(30, '-'));
            Console.WriteLine(Task4(3500, 13));
            Console.WriteLine(Task4(3500, -5));
        }

        public static string Task2(int number)
        {
            if ((number & 1) == 0)
            {
                return "The number is even.";
            }

            return "The number is odd.";
        }

        public static void Task3()
        {
            int x = 5, y = 10, z = 15;
            x += y >> x++ * z;
            Console.WriteLine(x);
            z = ++x & y * 5;
            Console.WriteLine(z);
            y /= x + 5 | z;
            Console.WriteLine(y);
            z = x++ & y * 5;
            Console.WriteLine(z);
            x = y << x++ ^ z;
            Console.WriteLine(x);
        }

        public static double Task4(double salary, int yearsOfService)
        {
            double bounty, seniorityMultiplier;
            switch (yearsOfService)
            {
                case int n when (n >= 0 && n < 5):
                    seniorityMultiplier = 10;
                    break;
                case int n when (n >= 5 && n < 10):
                    seniorityMultiplier = 15;
                    break;
                case int n when (n >= 10 && n < 15):
                    seniorityMultiplier = 25;
                    break;
                case int n when (n >= 15 && n < 20):
                    seniorityMultiplier = 35;
                    break;
                case int n when (n >= 20 && n < 25):
                    seniorityMultiplier = 45;
                    break;
                case int n when (n >= 25):
                    seniorityMultiplier = 50;
                    break;
                default:
                    throw new Exception();
            }

            bounty = salary * (seniorityMultiplier / 100);
            return salary + bounty;
        }
    }
}