using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
     class Book
    {
        public void FindNext(string str)
        {
            Console.WriteLine("Пошук рядка : " + str);
        }

        public class Notes
        {
            public void SaveNotes(string note)
            {
                Console.WriteLine($"{note} are save");
            }
        }
    }
}
