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
            int trainNumbers = 8;
            Train[] trains = new Train[trainNumbers];

            for (int i = 0; i < trainNumbers; i++)
            {
                Console.WriteLine($"Enter train informations:");
                string place = Console.ReadLine();
                int number; 
                int.TryParse(Console.ReadLine(),out number);
                string time = Console.ReadLine();

                trains[i] = new Train(place, number, time); 
            }

            trains.OrderBy(x => x._number);

        
            foreach (var tra in trains)
            {
                if (tra._number > 0)
                {
                    Console.WriteLine($"Train infirmation - {tra._place}, {tra._number}, {tra._time}");
                }
                else
                {
                    Console.WriteLine("Not number");
                }
            }

            Console.ReadKey();

        }
    }
}
