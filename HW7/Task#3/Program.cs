using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "змінено";
            
        }
        static void StruktTaker(ref MyStruct myStruct)
        {
            myStruct.change = "змінено";
        }

        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            MyStruct myStruct = new MyStruct();
            
            ClassTaker(myClass);
            Console.WriteLine("myClas1 " + myClass.change);

            StruktTaker(ref myStruct);
            Console.WriteLine("myStruct1 " + myStruct.change);

            myClass.change = "не змінено";
            myStruct.change = "не змінено";
            Console.WriteLine("myClas2 " + myClass.change);
            Console.WriteLine("myStruct2 " + myStruct.change);





            Console.ReadKey();
        }
    }
}
