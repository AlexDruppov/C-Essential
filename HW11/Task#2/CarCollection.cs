using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class CarCollection
    {
        private List<Car> car = new List<Car>();

        public void AddCar(string carName, int carYear)
        {
            car.Add(new Car(carName, carYear));
        }

        public Car this[int index]
        {
            get
            {
                return car[index];
            }
        }
        
        public int Count
        {
            get
            {
                return car.Count;
            }
        }

        public void Clear() 
        { 
            car.Clear();
            Console.WriteLine("List is clear");
        }
       
    }
}
