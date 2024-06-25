using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Dictionary<TKey, TValue>
    {
        private List<TKey> keys = new List<TKey>();
        private List<TValue> values = new List<TValue>();

        public void Add(TKey key, TValue value)
        {
            
            {
                keys.Add(key);
                values.Add(value);
            }
            
        }

        public TValue this[TKey key]
        {
            get
            {
                int index = keys.IndexOf(key);
                
                {
                    return values[index];
                }
               
            }
        }


        public TKey GetKey(int index)
        {
            return keys[index];
        }

        public TValue GetValue(int index)
        {
            return values[index];
        }

        public int Count
        {
            get 
            {
                return keys.Count; 
            }
        }

        public void Clear() 
        {
            keys.Clear();
            values.Clear();
        }
    }
}
