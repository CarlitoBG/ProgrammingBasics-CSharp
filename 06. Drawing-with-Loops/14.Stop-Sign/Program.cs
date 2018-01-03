using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stop_Sign
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var dots = n + 1;
            var underscore = (n * 2) + 1;

            Console.WriteLine("{0}{1}{0}", new string('.', dots),
                new string('_', underscore));

            dots -= 1;
            underscore -= 2;

            for (int row = 1; row <= n + 1; row++)
            {
                if (row == n + 1)
                {
                    Console.Write("{0}{1}{2}{1}{3}", "//",
                        new string('_', (underscore - 5) / 2), "STOP!", "\\\\");
                }
                else
                {
                    Console.Write("{0}{1}{2}{3}{0}", new string('.', dots), "//",
                        new string('_', underscore), "\\\\");
                }

                dots -= 1;
                underscore += 2;
                Console.WriteLine();
            }

            dots = 0;
            underscore -= 2;

            for (int row = 1; row <= n; row++)
            {
                Console.Write("{0}{1}{2}{3}{0}", new string('.', dots), "\\\\",
                    new string('_', underscore), "//");

                dots += 1;
                underscore -= 2;
                Console.WriteLine();
            }
        }
    }
}
