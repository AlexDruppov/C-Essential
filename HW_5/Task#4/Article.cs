using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Article
    {
        private string _product;
        private string _shop;
        private int _amount;

        public Article(string product, string shop, int amount) 
        {
            _product = product;
            _shop = shop;
            _amount = amount;
        }

        public string Staf
        {
            get
            {
                return ($"{_product}, {_shop}, {_amount} UAH");
            }
        }
        //public string Product
        //{ get { return _product; } }

        //public string Shop
        //{
        //    get { return _shop; }
        //}

        //public double Amount
        //{
        //    get { return _amount; }
        //}
    }
}
