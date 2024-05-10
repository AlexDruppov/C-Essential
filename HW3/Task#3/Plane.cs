using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Plane : Vehicle
    {
        private int _height;
        private int _passengersNumber;

        public Plane(int height, int passengers, double price, double speed, int year, int[] point)
            :base(price, speed, year, point)
        {
            _height = height;
            _passengersNumber = passengers;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Number of passangers is {_passengersNumber}");
            Console.WriteLine($"Heigh is {_height}");
        }

    }
}
