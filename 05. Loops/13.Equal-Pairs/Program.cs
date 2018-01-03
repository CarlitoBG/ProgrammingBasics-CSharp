using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sumCurrentPair = 0;
            var sumPreviousPair = 0;
            var maxDiff = 0;
            var currentDiff = 0;

            for (int i = 0; i < n; i++)
            {
                var firstNum = int.Parse(Console.ReadLine());
                var secondNum = int.Parse(Console.ReadLine());

                if (i == 0)
                {
                    sumPreviousPair = firstNum + secondNum;
                }
                else
                {
                    sumCurrentPair = firstNum + secondNum;
                    currentDiff = Math.Abs(sumCurrentPair - sumPreviousPair);

                    if (currentDiff > maxDiff)
                    {
                        maxDiff = currentDiff;
                    }

                    sumPreviousPair = sumCurrentPair;
                }
            }

            if (maxDiff == 0)
            {
                Console.WriteLine("Yes, value = {0}", sumPreviousPair);
            }
            else
            {
                Console.WriteLine("No, maxdiff = {0}", maxDiff);
            }   
        }
    }
}
