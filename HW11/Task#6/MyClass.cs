using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    internal class MyClass
    {
        public string Text { get; set; }

        public MyClass(string text) 
        {
            Text = text;
        }

        public override string ToString()
        {
            return $"MyClass: {Text}";
        }
    }
}
