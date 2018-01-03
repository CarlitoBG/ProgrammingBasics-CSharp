using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var periodOfDay = Console.ReadLine();
            var price = 0d;

            double taxiStartPrice = 0.70;
            double taxiDayPrice = 0.79;
            double taxiNightPrice = 0.90;
            double busPrice = 0.09;
            double trainPrice = 0.06;

            if (n < 20)
            {
                if (periodOfDay == "day")
                {
                    price = (taxiStartPrice + (n * taxiDayPrice));
                }
                else if (periodOfDay == "night")
                {
                    price = (taxiStartPrice + (n * taxiNightPrice));
                }
            }

            if (n >= 20 && n < 100)
            {
                price = n * busPrice;
            }
            else if (n >= 100)
            {
                price = n * trainPrice;
            }

            Console.WriteLine(price);
        }
    }
}
