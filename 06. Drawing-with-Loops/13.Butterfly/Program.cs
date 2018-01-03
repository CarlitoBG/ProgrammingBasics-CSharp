using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butterfly
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var colWidth = n - 1;
            var halfHeight = (2 * (n - 2) + 1) / 2;
           
            for (int row = 1; row <= halfHeight; row++)
            {
                if (row % 2 == 1)
                {
                    Console.WriteLine("{0}{1}{0}", new string('*', colWidth - 1), "\\ /");
                }
                else if (row % 2 == 0)
                {
                    Console.WriteLine("{0}{1}{0}", new string('-', colWidth - 1), "\\ /");
                }
            }

            Console.WriteLine("{0}{1}{0}", new string(' ', colWidth), '@');
            
            for (int row = 1; row <= halfHeight; row++)
            {
                if (row % 2 == 1)
                {
                    Console.WriteLine("{0}{1}{0}", new string('*', colWidth - 1), "/ \\");
                }
                else if (row % 2 == 0)
                {
                    Console.WriteLine("{0}{1}{0}", new string('-', colWidth - 1), "/ \\");
                }
            }
        }
    }
}
