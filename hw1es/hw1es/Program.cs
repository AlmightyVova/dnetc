using System;

namespace hw1es
{
    class Program
    {
        static void Main()
        {
            #region Task2

            Rectangle rec = new Rectangle(5, 8);
            Console.WriteLine(rec.Area);
            Console.WriteLine(rec.Perimeter);

            #endregion

            #region Task3

            Book book = new Book("Book", "Booker", "Hello world!");
            book.Show();

            #endregion

            #region Task4

            Task4.Figure figure = new Task4.Figure(new Task4.Point(3, 7, "A"), new Task4.Point(8, 9, "B"),
                new Task4.Point(13, -6, "C"));
            var length = figure.LengthSide(figure.P1, figure.P3);
            figure.PerimeterCalculator();
            Console.WriteLine(length);
            
            #endregion
        }
    }
}