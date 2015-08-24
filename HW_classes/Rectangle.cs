using System;

namespace HW_classes
{
    public class Rectangle
    {
        private double _side1;
        private double _side2;

        public Rectangle(double side1, double side2)
        {
            if (side1 <= 0 || side2 <= 0)
            {
                throw new ArgumentException("Sides can`t be negative");
            }
            _side1 = side1;
            _side2 = side2;
        }

        private double AreaCalculator()
        {
            return _side1 * _side2;
        }

        private double PerimeterCalculator()
        {
            return 2 * (_side1 + _side2);
        }

        public double Area
        {
            get { return AreaCalculator(); }
        }

        public double Perimeter
        {
            get { return PerimeterCalculator(); }
        }
    }
}