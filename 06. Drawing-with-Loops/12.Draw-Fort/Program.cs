using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw_Fort
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var colWidth = n / 2;
            var midCol = (n * 2) - (2 * (n / 2)) - 4;
            var midWidth = (n * 2) - 2;

            Console.Write("{0}{1}{2}", "/", new string('^', colWidth), "\\");
            if (n > 4)
            {
                Console.Write(new string('_', midCol));
            }
            Console.WriteLine("{0}{1}{2}", "/", new string('^', colWidth), "\\");

            if (n > 4)
            {
                for (int i = 1; i <= n - 2; i++)
                {
                    var blanks = (n + 2) / 2;

                    if (i != n - 2)
                    {
                        Console.Write("{0}{1}{0}", "|", new string(' ', midWidth));
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Write("{0}{1}{2}{1}{0}", "|",
                            new string(' ', blanks), new string('_', midCol));
                        Console.WriteLine();
                    }
                }
            }
            else if (n == 3 || n == 4)
            {
                for (int i = 0; i < n - 2; i++)
                {
                    Console.Write("{0}{1}{0}", "|", new string(' ', midWidth));
                    Console.WriteLine();
                }
            }

            Console.Write("{0}{1}{2}", "\\", new string('_',colWidth), "/");
            if (n > 4)
            {
                Console.Write(new string(' ', midCol));
            }
            Console.WriteLine("{0}{1}{2}", "\\", new string('_', colWidth), "/");
        }
    }
}
