using System;

namespace hw2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string
                s1 = "\nмоя строка 1",
                s2 = "\tмоя строка 2",
                s3 = "\aмоя строка 3";
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
        }
    }
}