using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter(39.39, 42.33, 9.64);
            
            double amountUSD = converter.ConverterUA(100, "usd");
            Console.WriteLine($"Конвертація становить {amountUSD} usd.");

            double amountEUR = converter.ConverterUA(100, "eur");
            Console.WriteLine($"Конвертація становить {amountEUR} eur.");

            double amountPLN = converter.ConverterUA(100, "pln");
            Console.WriteLine($"Конвертація становить {amountPLN} pln.");

            double amountUSD_UA = converter.ConverterAnotherMoney(100, "usd");
            Console.WriteLine($"Конвертація становить {amountUSD_UA} грн.");

            double amountEUR_UA = converter.ConverterAnotherMoney(100, "eur");
            Console.WriteLine($"Конвертація становить {amountEUR_UA} грн.");

            double amountPLN_UA = converter.ConverterAnotherMoney(100, "pln");
            Console.WriteLine($"Конвертація становить {amountPLN_UA} грн.");


            Console.ReadKey();
        }

        class Converter
        {
            double _usd;
            double _eur;
            double _pln;

            public Converter(double usd, double eur, double pln)
            {
                _usd = usd;
                _eur = eur;
                _pln = pln;
            }

            public double ConverterUA(double amount, string moneyType)
            {
                if (moneyType == "usd") 
                {
                    return amount / _usd;
                }
                else if (moneyType == "eur")
                {
                    return amount / _eur;
                }
                else if (moneyType == "pln")
                {
                    return amount / _pln;
                }
                else
                {
                    Console.WriteLine("такої валюти не існує");
                    return 0;
                }
            }

            public double ConverterAnotherMoney(double amount, string moneyType)
            {
                if (moneyType == "usd")
                {
                    return amount * _usd;
                }
                else if (moneyType == "eur")
                {
                    return amount * _eur;
                }
                else if (moneyType == "pln")
                {
                    return amount * _pln;
                }
                else
                {
                    Console.WriteLine("такої валюти не існує");
                    return 0;
                }
            }
        }
    }
}
