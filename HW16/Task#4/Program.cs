using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Date date1 = new Date(1, 01, 2001);
            Date date2 = new Date(2, 02, 2002);

            int newDate = date2 - date1;
            Console.WriteLine(newDate);

            Date someDate1 = date1 + 15;
            Console.WriteLine(someDate1);

            Date someDate2 = date2 + 15;
            Console.WriteLine(someDate2);

            Console.ReadKey();
        }
    }
}
