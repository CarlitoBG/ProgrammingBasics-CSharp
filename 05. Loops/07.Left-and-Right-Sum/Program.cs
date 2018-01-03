using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var sumLeft = 0;
            var sumRight = 0;

            for (int i = 0; i < n; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());
                sumLeft = sumLeft + currentNumber;
            }

            for (int i = 0; i < n; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());
                sumRight = sumRight + currentNumber;
            }

            if (sumLeft == sumRight)
            {
                Console.WriteLine("Yes, sum = " + sumLeft);
            }
            else
            {
                Console.WriteLine("No, diff = " + Math.Abs(sumLeft - sumRight));
            }
        }
    }
}
