using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            var sumOdd = 0.0;
            var sumEven = 0.0;
            var maxNumberEven = double.MinValue;
            var minNumberEven = double.MaxValue;
            var maxNumberOdd = double.MinValue;
            var minNumberOdd = double.MaxValue;

            for (int i = 1; i <= n; i++)
            {
                var num = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    sumEven = sumEven + num;

                    if (num > maxNumberEven)
                    {
                        maxNumberEven = num;
                    }

                    if (num < minNumberEven)
                    {
                        minNumberEven = num;
                    }
                }
                else if (i % 2 != 0)
                {
                    sumOdd = sumOdd + num;

                    if (num > maxNumberOdd)
                    {
                        maxNumberOdd = num;
                    }

                    if (num < minNumberOdd)
                    {
                        minNumberOdd = num;
                    }
                }
            }

            if (n == 1)
            {
                Console.WriteLine("OddSum = {0}", sumOdd);
                Console.WriteLine("OddMin = {0}", minNumberOdd);
                Console.WriteLine("OddMax = {0}", maxNumberOdd);
                Console.WriteLine("EvenSum = 0");
                Console.WriteLine("EvenMin = No");
                Console.WriteLine("EvenMax = No");
            }
            else if (n == 0)
            {
                Console.WriteLine("OddSum = 0");
                Console.WriteLine("OddMin = No");
                Console.WriteLine("OddMax = No");
                Console.WriteLine("EvenSum = 0");
                Console.WriteLine("EvenMin = No");
                Console.WriteLine("EvenMax = No");
            }
            else 
            {
                Console.WriteLine("OddSum = {0}", sumOdd);
                Console.WriteLine("OddMin = {0}", minNumberOdd);
                Console.WriteLine("OddMax = {0}", maxNumberOdd);
                Console.WriteLine("EvenSum = {0}", sumEven);
                Console.WriteLine("EvenMin = {0}", minNumberEven);
                Console.WriteLine("EvenMax = {0}", maxNumberEven);
            }
        }
    }
}
