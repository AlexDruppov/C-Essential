using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Ship : Vehicle
    {
        public int _passengersNumber;
        public string _port;

        public Ship(int passangers, string port, double price, double speed, int year, int[] point) 
            : base(price, speed, year, point)
        {
            _passengersNumber = passangers;
            _port = port;
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Number of passangers is {_passengersNumber}");
            Console.WriteLine($"Port is {_port}");
        }

    }  
}
