using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your birth day (yaer-mounth-day)");
            string bd = Console.ReadLine();
            
            DateTime birthDate;
            if (!DateTime.TryParse(bd, out birthDate))
            {
                Console.WriteLine("Invalid format");
                return;
            }
           
                DateTime today = DateTime.Today;
                DateTime nextBirthDay = new DateTime(today.Year, birthDate.Month, birthDate.Day);

                int days = (nextBirthDay - today).Days;
                Console.WriteLine($"your next Birth Day is {days}");

            
            Console.ReadKey();
        }
    }
}
