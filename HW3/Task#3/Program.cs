using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Ship ship = new Ship(1536, "Gavana", 15000, 120, 1980, new int[] {1200, 3697});
            Car car = new Car(20000, 320, 2022, new int[] {0012, 4899});
            Plane plane = new Plane(9, 200, 900000, 4000, 2005, new int[] { 1111, 9637 });

            ship.Show();
            car.Show();
            plane.Show();

            Console.ReadLine();
        }
    }
}
