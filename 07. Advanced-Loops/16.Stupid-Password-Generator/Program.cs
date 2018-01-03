using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stupid_Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var l = int.Parse(Console.ReadLine());

            for (int dig1 = 1; dig1 <= n; dig1++)
            {
                for (int dig2 = 1; dig2 <= n; dig2++)
                {
                    for (var let1 = 'a'; let1 < 'a' + l; let1++)
                    {
                        for (var let2 = 'a'; let2 < 'a' + l; let2++)
                        {
                            for (int dig3 = Math.Max(dig1, dig2) + 1; dig3 <= n; dig3++)
                            {
                                Console.Write("{0}{1}{2}{3}{4} ",
                                    dig1, dig2, let1, let2, dig3);
                            }
                        }
                    }
                }
            }

            Console.WriteLine();
        }
    }
}
