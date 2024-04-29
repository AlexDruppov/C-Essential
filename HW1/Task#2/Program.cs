using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть сторону а:");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введіть сторону b:");
            double b = double.Parse(Console.ReadLine());

            Rectangle rectangle = new Rectangle(a, b);

            Console.WriteLine($"Периметр - {rectangle.Perimeter}");
            Console.WriteLine($"Площа - {rectangle.Area}");

            Console.ReadKey();
        }
    }

    class Rectangle
    {
        double _side1;
        double _side2;

        public Rectangle(double a, double b)
        {
            _side1 = a;
            _side2 = b;
        }

        public double AreaCalculator()
        {
            return _side1 * _side2;
        }

        public double Area
        {
            get
            {
                return AreaCalculator();
            }

        }

        public double PerimeterCalculator()
        {
            return (_side1 + _side2) * 2;
        }

        public double Perimeter
        {
            get
            {
                return PerimeterCalculator();
            }

        }

    }
}
