using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Vehicle
    {
        public int[] _point;
        public double _price;
        public double _speed;
        public int _year;

        public Vehicle(double price, double speed, int year, int[] point) 
        {
            _price = price;
            _speed = speed;
            _year = year;
            _point = point;
        }

        public virtual void Show()
        {
            Console.WriteLine($"Price is {_price}");
            Console.WriteLine($"Speed is {_speed}");
            Console.WriteLine($"Year is {_year}");
            Console.WriteLine("Coordinates is:");
            foreach (int coord in _point)
            {
                Console.Write(coord + " ");
            }
            Console.WriteLine();
        }
    }
}
