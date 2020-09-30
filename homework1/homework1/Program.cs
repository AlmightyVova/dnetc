using System;

namespace homework1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            task1();
            task2();
            task3();
            task4();
        }

        public static void task1()
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

        public static void task2()
        {
            const int x = 5, y = 6, z = 2;
            const int sum = x + y + z;
            const int average = sum / 3;
            Console.WriteLine("task2 sum: "+sum);
            Console.WriteLine("task2 average: "+average);
        }

        public static void task3()
        {
            const double pi = 3.14;
            double r = 17;
            double S = pi * Math.Pow(r, 2);
            Console.WriteLine("task3: r = {0}, S = {1}",r,S);
        }

        public static void task4()
        {
            const double pi = 3.14;
            double R = 3, h = 7;
            double V, S;
            V = pi * Math.Pow(R, 2) * h;
            S = 2 * pi * R*(R + h);
            Console.WriteLine("task4: R = {0}, h = {1}, V = {2}, S = {3}",R,h,V,S);
        }
    }
}