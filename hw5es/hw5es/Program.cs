using System;
using System.Collections.Generic;
using System.Linq;

namespace hw5es
{
    class Program
    {
        static Random _random = new Random();

        static void Main()
        {
            #region Task 2

            int[] arr = GetRandomArray(_random.Next(0, 100));
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }

            Console.WriteLine();

            Console.WriteLine(GetMax(arr));
            Console.WriteLine(GetMin(arr));
            Console.WriteLine(GetSum(arr));

            #endregion

            Console.WriteLine("\n" + "\n".PadLeft(50, '='));

            #region Task 3

            MyMatrix matrix = new MyMatrix(3, 4);
            matrix.OutputMatrix();

            Console.WriteLine();

            matrix.OutputInnerMatrices();

            #endregion

            #region Task 4

            Store store = new Store(
                new Article("Ar1", "Bear", 500),
                new Article("Cow", "Cow farm", 700),
                new Article("Robot Bear", "Robot Shop", 1200),
                new Article("Robot Bear", "Bear Shop", 1700),
                new Article("Some other thing", "Some shop", 500),
                new Article("Some other thing", "Some shop", 500));
            
            store.GetByName("Robot Bear");
            store.GetByIndex(1);

            #endregion

            Console.ReadKey();
        }

        static int GetSum(int[] arr)
        {
            int sum = 0;

            foreach (var i in arr)
            {
                sum += i;
            }

            return sum;
        }

        static int GetAverage(int[] arr)
        {
            return GetSum(arr) / arr.Length;
        }

        static List<int> GetOdd(int[] arr)
        {
            List<int> oddList = new List<int>();

            foreach (var i in arr)
            {
                if (i % 2 == 1)
                {
                    oddList.Add(i);
                }
            }

            return oddList;
        }

        static int[] GetRandomArray(int length)
        {
            int[] arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                arr[i] = _random.Next(0, 100);
            }

            return arr;
        }

        static int GetMax(int[] arr)
        {
            int max = arr[0];

            foreach (var t in arr)
            {
                if (t > max) max = t;
            }

            return max;
        }

        static int GetMin(int[] arr)
        {
            int min = arr[0];

            foreach (var t in arr)
            {
                if (t < min) min = t;
            }

            return min;
        }
    }
}