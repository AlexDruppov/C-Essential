using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Price[] prices = new Price[2];

            for (int i = 0; i < prices.Length; i++)
            {
                Console.WriteLine("Enter product");
                string product = Console.ReadLine();

                Console.WriteLine("Enter store");
                string store = Console.ReadLine();

                Console.WriteLine("Enter price");
                int price = int.Parse(Console.ReadLine());

                prices[i] = new Price(product, store, price);
            }

            prices = prices.OrderBy(x => x.Store).ToArray();

            foreach (var item in prices)
            {
                Console.WriteLine($"{item.Name}, {item.Store}, {item.Prices}");
            }

            Console.WriteLine("Enter store");
            string searchStoreProduct = Console.ReadLine();

            try
            {
                var storeProducts = prices.Where(x => x.Store.Equals(searchStoreProduct, StringComparison.OrdinalIgnoreCase)).ToList();


                if (storeProducts.Count == 0)
                {
                    throw new Exception("Error store");
                }

                foreach (var item in storeProducts)
                {
                    Console.WriteLine($"{searchStoreProduct}: {item.Name}, {item.Prices}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        } 
    }
}
