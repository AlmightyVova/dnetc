using System;

namespace hw7
{
    class Program
    {
        private static void Main()
        {
            int[] tests = {17, 13, 23, 83, 89, 97, 98, 100};
            for (int i = 0; i < tests.Length-1; i++)
            {
            CallEach(tests[i],tests[i+1]);    
            }
            CallEach(tests[^1]);
        }

        private static void CallEach(int a, int b = 0)
        {
            Console.WriteLine($"{a}, b = {b}: ");
            Task2Add(a,b);
            Task2Sub(a,b);
            Task2Mul(a,b);
            Task2Div(a,b);
            Task3(a);
            Task4(a);
        }
        
        private static void Task2Add(int a, int b)
        {
            Console.WriteLine($"Task2Add: {a+b}");
        }

        private static void Task2Sub(int a, int b)
        {
            Console.WriteLine($"Task2Sub: {a-b}");
        }

        private static void Task2Mul(int a, int b)
        {
            Console.WriteLine($"Task2Mul: {a*b}");
        }

        private static void Task2Div(int a, int b)
        {
            Console.WriteLine(b == 0 ? "Task2Div: Division by zero" : $"Task2Div: {a/b}");
        }

        private static void Task3(double uah)
        {
            double usd = uah / 28;
            Console.WriteLine($"Task3: {usd}");
        }

        private static void Task4(int number)
        {
            bool isPrime = true;
            if (number > 0)
            {
                Console.WriteLine("Task4: This is a positive number");

                if (number == 2) isPrime = false;
                if (number % 2 == 0) isPrime = false;

                var boundary = (int) Math.Floor(Math.Sqrt(number));

                for (int i = 3; i <= boundary; i += 2)
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }

                Console.WriteLine(isPrime ? "Task4: The number is prime" : "Task4: The number isn't prime");
            }
            else
            {
                Console.WriteLine("Task4: This is a negative number");
                Console.WriteLine("Task4: The number isn't prime");
            }

            if (isPrime) return;
            switch (number)
            {
                case var num when num % 2 == 0:
                    Console.WriteLine("Task4: Dividable by 2 w/o remainder");
                    break;
                case var num when num % 5 == 0:
                    Console.WriteLine("Task4: Dividable by 5 w/o remainder");
                    break;
                case var num when num % 3 == 0:
                    Console.WriteLine("Task4: Dividable by 3 w/o remainder");
                    break;
                case var num when num % 6 == 0:
                    Console.WriteLine("Task4: Dividable by 6 w/o remainder");
                    break;
                case var num when num % 9 == 0:
                    Console.WriteLine("Task4: Dividable by 9 w/o remainder");
                    break;
            }
        }
    }
}