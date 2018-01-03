using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var currentMax = int.Parse(Console.ReadLine());

            for (int i = 0; i < n - 1 ; i++)
            {
                var num = int.Parse(Console.ReadLine());

                if (num >= currentMax)
                {
                    currentMax = num;
                }
            }

            Console.WriteLine(currentMax);
        }
    }
}
