using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Calculator
    {
        public dynamic Add(dynamic x, dynamic y)
        {
            return x + y;
        }

        public dynamic Sub(dynamic x, dynamic y)
        {
            return x - y;
        }

        public dynamic Mul(dynamic x, dynamic y)
        {
            return x * y;
        }

        public dynamic Div(dynamic x, dynamic y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException("Error");
            }
            return x / y;
        }
    }
}
