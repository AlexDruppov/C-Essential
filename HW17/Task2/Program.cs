using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>
            {
                new Car
                {
                    Make = "Ford", Model = "Mustang", Year = 1967, Color = "Black"
                },
                new Car
                {
                    Make = "Chevrole", Model = "Corvet", Year = 1969, Color = "Silver"
                },
                new Car
                {
                    Make = "Dodge", Model = "Challenger", Year = 1969, Color = "Yellow"
                },
            };

            var clients = new List<Client>
            {
                new Client
                {
                    Model = "Challenger", ClientName = "Alex", ClientNumber = "555666777"
                },
                new Client
                {
                    Model = "Mustang", ClientName = "Bob", ClientNumber = "111999777"
                }
            };

            var query = from car in cars
                        join client in clients
                        on car.Model equals client.Model
                        select new
                        {
                            client.ClientName,
                            client.ClientNumber,
                            car.Make,
                            car.Model,
                            car.Year,
                            car.Color
                        };

            foreach (var item in query)
            {
                Console.WriteLine($"{item.ClientName} (Phone - {item.ClientNumber}) : {item.Color} {item.Make} {item.Model} - {item.Year}");
            }

            Console.ReadKey();
        }
    }
}
