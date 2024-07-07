using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    public static class EnumerableExtensions
    {
        public static T[] GetArray<T>(this IEnumerable<T> list)
        {
            List<T> tempList = new List<T>();
            foreach (var item in list)
            {
                tempList.Add(item);
            }
            return tempList.ToArray();
        }
    }
}
