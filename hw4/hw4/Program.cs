using System;

namespace hw4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Task2();
            Console.WriteLine("".PadLeft(30, '-'));
            Task3();
            Console.WriteLine("".PadLeft(30, '-'));
        }

        public static void Task2()
        {
            double operand1 = 3, operand2 = 5;
            string userInput = Console.ReadLine();

            string sign;
            switch (userInput[0])
            {
                case '+':
                    sign = $"{operand1 + operand2}";
                    break;
                case '-':
                    sign = $"{operand1 - operand2}";
                    break;
                case '/':
                    if (operand2 == 0)
                    {
                        sign = "Dividing by zero. Operation halted.";
                    }

                    sign = $"{operand1 / operand2}";

                    break;
                case '*':
                    sign = $"{operand1 * operand2}";

                    break;
                case '^':
                    sign = $"{Math.Pow(operand1, operand2)}";
                    break;
                default:
                    sign = "You've entered something unpredicted.";
                    break;
            }

            Console.WriteLine(sign);
        }

        public static void Task3()
        {
            string userInput = Console.ReadLine();
            int number;
            if (Int32.TryParse(userInput, out number))
            {
                Console.WriteLine($"Parsed: {number}");
                switch (number)
                {
                    case int n when (n >= 0 && n <= 14):
                        Console.WriteLine($"The number {n} is in range [0-14].");
                        break;
                    case int n when (n >= 15 && n <= 35):
                        Console.WriteLine($"The number {n} is in range [15-35].");
                        break;
                    case int n when (n >= 36 && n <= 50):
                        Console.WriteLine($"The number {n} is in range [36-50].");
                        break;
                    case int n when (n >= 51 && n <= 100):
                        Console.WriteLine($"The number {n} is in range [51-100].");
                        break;
                    default:
                        Console.WriteLine("Number is not in any of the defined ranges.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("You entered not a number.");
            }
        }
    }
}