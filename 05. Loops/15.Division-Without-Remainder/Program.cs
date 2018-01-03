using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Division_without_Remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var counterTwo = 0d;
            var counterThree = 0d;
            var counterFour = 0d;

            for (int i = 1; i <= n; i++)
            {
                var num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    counterTwo += 1;
                }

                if (num % 3 == 0)
                {
                    counterThree += 1;
                }

                if (num % 4 == 0)
                {
                    counterFour += 1;
                }
            }

            Console.WriteLine("{0:f2}%", ((counterTwo / n) * 100));
            Console.WriteLine("{0:f2}%", ((counterThree / n) * 100));
            Console.WriteLine("{0:f2}%", ((counterFour / n) * 100));
        }
    }
}
