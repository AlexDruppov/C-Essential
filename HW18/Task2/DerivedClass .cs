using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class DerivedClass : BaseClass
    {
        public void FromBaseMethod()
        {
            Console.WriteLine("From DerivedClass");
            PublicMethod();
        }
    }
}
