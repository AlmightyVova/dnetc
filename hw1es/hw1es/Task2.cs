namespace hw1es
{
    class Rectangle
    {
        private readonly double _side1, _side2;

        public double Area => AreaCalc();
        public double Perimeter => PerimeterCalc();

        public Rectangle(double side1, double side2)
        {
            _side1 = side1;
            _side2 = side2;
        }

        private double AreaCalc()
        {
            return _side1 * _side2;
        }

        private double PerimeterCalc()
        {
            return _side1 * 4;
        }
    }
}