using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConvertor
{
    class Program
    {
        static void Main(string[] args)
        {
            var value = decimal.Parse(Console.ReadLine());
            var inputCurrency = Console.ReadLine();
            var outputCurrency = Console.ReadLine();
            decimal BGN, USD, EUR, GBP;

            while (inputCurrency == "BGN")
            {
                if (outputCurrency == "USD")
                {
                    USD = value / 1.79549m;
                    Console.WriteLine(Math.Round(USD, 2) + " " + outputCurrency);
                    break;
                }

                if (outputCurrency == "EUR")
                {
                    EUR = value / 1.95583m;
                    Console.WriteLine(Math.Round(EUR, 2) + " " + outputCurrency);
                    break;
                }

                if (outputCurrency == "GBP")
                {
                    GBP = value / 2.53405m;
                    Console.WriteLine(Math.Round(GBP, 2) + " " + outputCurrency);
                    break;
                }
            }

            while (inputCurrency == "USD")
            {
                if (outputCurrency == "BGN")
                {
                    BGN = value * 1.79549m;
                    Console.WriteLine(Math.Round(BGN, 2) + " " + outputCurrency);
                    break;
                }

                if (outputCurrency == "EUR")
                {
                    EUR = (value * 1.79549m) / 1.95583m;
                    Console.WriteLine(Math.Round(EUR, 2) + " " + outputCurrency);
                    break;
                }

                if (outputCurrency == "GBP")
                {
                    GBP = (value * 1.79549m) / 2.53405m;
                    Console.WriteLine(Math.Round(GBP, 2) + " " + outputCurrency);
                    break;
                }
            }

            while (inputCurrency == "EUR")
            {
                if (outputCurrency == "BGN")
                {
                    BGN = value * 1.95583m;
                    Console.WriteLine(Math.Round(BGN, 2) + " " + outputCurrency);
                    break;
                }

                if (outputCurrency == "USD")
                {
                    USD = (value * 1.95583m) / 1.79549m;
                    Console.WriteLine(Math.Round(USD, 2) + " " + outputCurrency);
                    break;
                }

                if (outputCurrency == "GBP")
                {
                    GBP = (value * 1.95583m) / 2.53405m;
                    Console.WriteLine(Math.Round(GBP, 2) + " " + outputCurrency);
                    break;
                }
            }

            while (inputCurrency == "GBP")
            {
                if (outputCurrency == "BGN")
                {
                    BGN = value * 2.53405m;
                    Console.WriteLine(Math.Round(BGN, 2) + " " + outputCurrency);
                    break;
                }

                if (outputCurrency == "USD")
                {
                    USD = (value * 2.53405m) / 1.79549m;
                    Console.WriteLine(Math.Round(USD, 2) + " " + outputCurrency);
                    break;
                }

                if (outputCurrency == "EUR")
                {
                    EUR = (value * 2.53405m) / 1.95583m;
                    Console.WriteLine(Math.Round(EUR, 2) + " " + outputCurrency);
                    break;
                }
            }
        }
    }
}
