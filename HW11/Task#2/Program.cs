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
            CarCollection car = new CarCollection();
            car.AddCar("Mustang", 1967);
            car.AddCar("Chelenger", 1968);
            car.AddCar("Viper", 2016);
            car.AddCar("Corvet", 1969);

            for(int i = 0; i < car.Count; i++) 
            {
                Console.WriteLine(car[i]);
            }

            Console.WriteLine($"All number of cars is {car.Count}");

            car.Clear();

            Console.WriteLine(car.Count);

            Console.ReadKey();
        }
    }
}
