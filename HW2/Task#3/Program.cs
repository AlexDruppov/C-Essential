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
            Employee employee = new Employee("Олександр", "Олександров", "Менеджер");
            employee.Info(7, 1600);

            Console.ReadKey();
        }

        class Employee
        {
            string _firstName;
            string _lastName;
            string _position;

            public Employee(string firstName, string lastName, string position) 
            {
                _firstName = firstName;
                _lastName = lastName;
                _position = position;
            }

            public double TotalSalary(int experiens, int rate)
            {
                double amount = 0;
                if (experiens < 10)
                {
                    amount = rate + 1000;
                }
                else if (experiens >= 10) 
                {
                    amount = rate * 2500;
                }
                return amount;
            }

            public double Tax(double amount)
            {
                double tax = 0.15;
                double taxAmount = amount * tax;
                return taxAmount;
            }

            public void Info(int experiens, int rate)
            {
                double salary = TotalSalary(experiens, rate);
                double tax = Tax(salary);

                Console.WriteLine(_firstName);
                Console.WriteLine(_lastName);
                Console.WriteLine(_position);
                Console.WriteLine(experiens);
                Console.WriteLine(salary);
                Console.WriteLine(tax);
            }
        }
    }
}
