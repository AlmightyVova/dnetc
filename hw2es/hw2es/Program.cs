using System;

namespace hw2es
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 2

            var converter = new Converter(28.5, 33.8, 0.34);
            Console.WriteLine(converter.UsdToUah(150));
            Console.WriteLine(converter.EurToUah(150));
            Console.WriteLine(converter.RubToUah(150));
            Console.WriteLine(converter.UahToUsd(150));
            Console.WriteLine(converter.UahToEur(150));
            Console.WriteLine(converter.UahToRub(150));

            #endregion

            #region Task 3

            var employee = new Employee("Ihor", "Iwanowicz");
            employee.SetPost(Posts.Senior);
            employee.SetLengthOfService(5);
            employee.CalculateSalary();
            employee.Display();
            
            #endregion

            #region Task 4

            var invoice = new Invoice(0, "Hello", "World");
            Console.WriteLine(invoice.CalculatePriceWithVAT(500));
            Console.WriteLine(invoice.CalculatePriceWithoutVAT(500));
            
            #endregion

        }
    }
}