using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class ArrayList
    {
        private object[] _array;
        private int _index;

        public ArrayList() 
        {
            _array = new object[4];
            _index = 0;
        }

        public void Add(object value) 
        {
            _array[_index++] = value;
        }

        public object this[int index]
        {
            get
            {
                if (index < 0 || index >= _index)
                {
                    throw new ArgumentOutOfRangeException(nameof(index), "Index out of range");
                }
                return _array[index];
            }
            set
            {
                if (index < 0 || index >= _index)
                {
                    throw new ArgumentOutOfRangeException(nameof(index), "Index out of range");
                }
                _array[index] = value;
            }
        }

        
        public int Count
        {
            get { return _index; }
        }

        
        public void Clear()
        {
            _array = new object[4];
            _index = 0;
        }
    }
}
