using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(666, "Customer", "Provider", "Article", 6);

            double pricePDF = invoice.AmountPDF(150, 10);
            double price = invoice.Amount(150);

            Console.WriteLine($"Загальна сумма замовлення(включно з ПДФ) {pricePDF}");
            Console.WriteLine($"Cумма замовлення {price}");

            Console.ReadKey();
        }

        class Invoice
        {
            private readonly int _account;
            private readonly string _customer;
            private readonly string _provider;
            private string _article;
            private int _quantity;

            public Invoice(int account, string customer, string provider, string article, int quantity)
            {
                _account = account;
                _customer = customer;
                _provider = provider;
                _article = article;
                _quantity = quantity;
            }

            public double AmountPDF(double price, double pdf)
            {
                double amount = price * _quantity;
                double pdfAmount = amount * pdf;
                return amount + pdfAmount;
            } 

            public double Amount(double price)
            {
                return price * _quantity;
            }
        }
    }
}
