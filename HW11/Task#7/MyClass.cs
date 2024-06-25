using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    class MyClass
    {
        public static T FactoryMethod<T>(T value)
        {
            return value;
        }
    }
}
