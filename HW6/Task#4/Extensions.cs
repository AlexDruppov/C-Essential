using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    static class Extensions
    {
        public static void SortArray(this int[] array)
        {
            Array.Sort(array);
        }
    }
}
