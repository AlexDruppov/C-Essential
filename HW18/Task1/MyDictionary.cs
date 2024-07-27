using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class MyDictionary<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>
    {
        private List<TKey> _keys = new List<TKey>();
        private List<TValue> _values = new List<TValue>();

        public void Add(TKey key, TValue value)
        {
            _keys.Add(key);
            _values.Add(value);
        }

        public TValue this[TKey key]
        {
            get
            {
                int index = _keys.IndexOf(key);
                if (index >= 0)
                {
                    return _values[index];
                }
                throw new KeyNotFoundException($"The key '{key}' not found!");
            }
        }

        public int Count
        {
            get { return _keys.Count; }
        }

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            for (int i = 0; i < _keys.Count; i++)
            {
                yield return new KeyValuePair<TKey, TValue>(_keys[i], _values[i]);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

}

