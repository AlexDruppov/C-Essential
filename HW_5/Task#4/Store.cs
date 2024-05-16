using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Store
    {
        private Article[] articles;

        public Store(int num)
        {
            articles = new Article[num];
        }

        public Article this[int index]
        {
            get { return articles[index]; }
            set { articles[index] = value; }
        }

        public void ArticleInfo(int index)
        {
            if (index >=0 && index < articles.Length) 
            {
                Console.WriteLine($"Info about product - {articles[index].Staf}");
                //Console.WriteLine($"Product: {articles[index].Product}");
                //Console.WriteLine($"Store: {articles[index].Shop}");
                //Console.WriteLine($"Price: {articles[index].Amount} UAH");
            }
            else
            {
                Console.WriteLine("Product index not found");
            }
        }
    }
}
