using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Lex66", "Luxor", "luxoroff", 66, DateTime.Now);
            user.Print();

            Console.ReadKey();
        }

        class User
        {
            private string _login;
            private string _firstName;
            private string _lastName;
            private int _age;
            private readonly DateTime _registrationDate;

            public User(string login, string firstName, string lastName, int age, DateTime registrationDate)
            {
                _login = login;
                _firstName = firstName;
                _lastName = lastName;
                _age = age;
                _registrationDate = registrationDate;
            }

            public void Print()
            {
                Console.WriteLine(_login);
                Console.WriteLine(_firstName);
                Console.WriteLine(_lastName);
                Console.WriteLine(_age);
                Console.WriteLine(_registrationDate);
            }
        }
    }
}
