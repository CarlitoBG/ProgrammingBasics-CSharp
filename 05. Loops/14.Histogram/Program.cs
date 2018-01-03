using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var counterTwoHundred = 0d;
            var counterFourHundred = 0d;
            var counterSixHundred = 0d;
            var counterEightHundred = 0d;
            var counterThousand = 0d;

            for (int i = 1; i <= n; i++)
            {
                var num = int.Parse(Console.ReadLine());

                if (num >= 1 && num < 200)
                {
                    counterTwoHundred += 1;  
                }
                else if (num >= 200 && num < 400)
                {
                    counterFourHundred += 1;
                }
                else if (num >= 400 && num < 600)
                {
                    counterSixHundred += 1;
                }
                else if (num >= 600 && num < 800)
                {
                    counterEightHundred += 1;
                }
                else if (num >= 800 && num <= 1000)
                {
                    counterThousand += 1;
                }
            }

            Console.WriteLine("{0:f2}%", ((counterTwoHundred / n) * 100));
            Console.WriteLine("{0:f2}%", ((counterFourHundred / n) * 100));
            Console.WriteLine("{0:f2}%", ((counterSixHundred / n) * 100));
            Console.WriteLine("{0:f2}%", ((counterEightHundred / n) * 100));
            Console.WriteLine("{0:f2}%", ((counterThousand / n) * 100));
        }
    }
}
