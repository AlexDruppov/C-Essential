using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Car : Vehicle
    {
        public Car (double price, double speed, int year, int[] point)
            : base(price, speed, year, point) 
        {

        }
        public override void Show()
        {
            base.Show();
        }
    }
}
