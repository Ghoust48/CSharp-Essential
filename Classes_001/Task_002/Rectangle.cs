namespace Task_002
{
    public class Rectangle
    {
        private double _firstSide;
        private double _secondSide;

        public double Area => AreaCalculator();
        public double Perimeter => PerimeterCalculator();

        public Rectangle(double firstSide, double secondSide)
        {
            _firstSide = firstSide;
            _secondSide = secondSide;
        }

        private double AreaCalculator()
        {
            return _firstSide * _secondSide;
        }

        private double PerimeterCalculator()
        {
            return 2 * (_firstSide + _secondSide);
        }
    }
}