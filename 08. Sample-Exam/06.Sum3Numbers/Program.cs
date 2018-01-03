using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());

            if (a + b == c)
            {
                Console.WriteLine("{0} + {1} = {2}", Math.Min(a, b), Math.Max(a, b), c);
            }
            else if (a + c == b)
            {
                Console.WriteLine("{0} + {1} = {2}", Math.Min(a, c), Math.Max(a, c), b);
            }
            else if (c + b == a)
            {
                Console.WriteLine("{0} + {1} = {2}", Math.Min(c, b), Math.Max(c, b), a);
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
