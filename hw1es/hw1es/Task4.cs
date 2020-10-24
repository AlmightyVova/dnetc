using System;

namespace hw1es
{
    public class Task4
    {
        public class Point
        {
            public int X { get; }
            public int Y { get; }
            public string Name { get; }

            public Point(int i1, int i2, string s = "")
            {
                s = $"Point({i1},{i2})";
                X = i1;
                Y = i2;
                Name = s;
            }
        }

        public class Figure
        {
            public readonly Point P1, P2, P3, P4, P5;

            public Figure(Point p1, Point p2, Point p3)
            {
                P1 = p1;
                P2 = p2;
                P3 = p3;
            }

            public Figure(Point p1, Point p2, Point p3, Point p4) : this(p1, p2, p3)
            {
                P4 = p4;
            }

            public Figure(Point p1, Point p2, Point p3, Point p4, Point p5) : this(p1, p2, p3, p4)
            {
                P5 = p5;
            }

            public double LengthSide(Point a, Point b)
            {
                double length = Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2));
                return length;
            }

            public void PerimeterCalculator()
            {
                var perimeter = LengthSide(P1, P2) + LengthSide(P2, P3);
                if (P4 != null)
                {
                    perimeter += LengthSide(P3, P4);
                    if (P5 != null)
                    {
                        perimeter += LengthSide(P4, P5) + LengthSide(P5, P1);
                    }
                }

                Console.WriteLine($"Perimeter: {perimeter}");
            }
        }
    }
}