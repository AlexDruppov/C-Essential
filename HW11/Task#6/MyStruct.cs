using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    internal class MyStruct
    {
        public int Number { get; set; }
        
        public MyStruct(int number) 
        {
            Number = number;
        }

        public override string ToString()
        {
            return $"MyStruct: {Number}";
        }

    }
}
