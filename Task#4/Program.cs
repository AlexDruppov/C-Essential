using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point(0, 0, "a");
            Point b = new Point(3, 0, "b");
            Point c = new Point(3, 4, "c");
            Point d = new Point(0, 4, "d");

            Figure figure = new Figure(a, b, c, d);
            figure.PerimeterCalculator();
            Console.ReadKey();

        }
    }
    class Point
    {
        int _a;
        int _b;
        string _text;

        public Point(int a, int b, string text)
        {
            _a = a;
            _b = b;
            _text = text;
        }

        public int A => _a;
        public int B => _b;
        public string Text => _text;
    }

    class Figure
    {
        Point[] _points;

        public Figure(params Point[] points)
        {
            _points = points;
        }

        private double LengthSide(Point point1, Point point2)
        {
            return Math.Sqrt(Math.Pow(point2.A - point1.A, 2) + Math.Pow(point2.A - point1.A, 2));
        }

        public void PerimeterCalculator()
        {
            double perimeter = 0;
            
            for (int i = 0; i < _points.Length - 1; i++)
            {
                perimeter += LengthSide(_points[i], _points[i + 1]);
            }
            perimeter += LengthSide(_points[_points.Length - 1], _points[0]);
            Console.WriteLine($"Назва багатокутника: {_points[0].Text}{_points.Length}, Периметр: {perimeter}");
        }
    }
}
