using System;
using System.Collections.Generic;

namespace HW_classes_task2
{
    public class Figure
    {
        private List<Point> _points = new List<Point>();

        public string GetName()
        {
            switch (_points.Count)
            {
                case 3:
                    return "Triangle";
                case 4:
                    return "Quadrangle";
                case 5:
                    return "Pentagon";
            }

            return "NoName";
        }

        public Figure(Point point1, Point point2, Point point3)
        {
            _points.Add(point1);
            _points.Add(point2);
            _points.Add(point3);
        }

        public Figure(Point point1, Point point2, Point point3, Point point4)
        {
            _points.Add(point1);
            _points.Add(point2);
            _points.Add(point3);
            _points.Add(point4);
        }

        public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
        {
            _points.Add(point1);
            _points.Add(point2);
            _points.Add(point3);
            _points.Add(point4);
            _points.Add(point5);
        }

        private double LengthSide(Point pointA, Point pointB)
        {
            return Math.Sqrt(Math.Pow(pointB.X - pointA.X, 2) + Math.Pow(pointB.Y - pointA.Y, 2));
        }

        public double PerimeterCalculator()
        {
            double perimeter = 0;
            for (int i = 0; i < _points.Count; i++) {
                perimeter += LengthSide(_points[i], _points[(i + 1) % _points.Count]);
            }
            return perimeter;
        }
    }
}