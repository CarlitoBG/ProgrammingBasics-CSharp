using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Console.Write(new string(' ', n));
            Console.Write(" | ");
            Console.WriteLine(new string(' ', n));

            var blanks = n - 1;
            var stars = 1;

            for (int i = 0; i < n; i++)
            {
                Console.Write(new string(' ', blanks));
                Console.Write(new string('*', stars));
                Console.Write(" | ");
                Console.Write(new string('*', stars));
                Console.Write(new string(' ', blanks));

                blanks--;
                stars++;
                Console.WriteLine();
            }
        }
    }
}
