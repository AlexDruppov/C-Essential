using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class MyList<T>
    {
        private T[] items;
        private int count;

        public MyList() 
        {
            items = new T[3];
            count = 0;
        }

        private void Resize()
        {
            T[] values = new T[items.Length * 2];
            for (int i = 0; i < items.Length; i++)
            {
                values[i] = items[i];
            }
            items = values;
        }

        public void Add(T item)
        {
            if (count == items.Length)
            {
                Resize();
            }
            items[count] = item;
            count++;
        }

        public T this[int index]
        {
            get
            {
                if (index  < 0 || index >= count)
                {
                    return default(T);
                }
                return items[index];
            }
        }

        public int Count
        {
            get { return count; }
        }

        
    }
}
