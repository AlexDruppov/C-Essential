using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    struct Price
    {
        public string Name;
        public string Store;
        public int Prices;

        public Price(string name, string store, int price)
        {
            Name = name;
            Store = store;
            Prices = price;
        }    
    }
}
