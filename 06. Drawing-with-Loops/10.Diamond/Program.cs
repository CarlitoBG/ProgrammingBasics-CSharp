﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var leftRight = (n - 1) / 2;
            var stars = 1;
            var mid = 1;

            if (n % 2 == 0)
            {
                leftRight = (n - 2) / 2;
                stars = 2;
                mid = 2;
            }

            Console.WriteLine("{0}{1}{0}", new string('-', leftRight),
                new string('*', stars));

            leftRight -= 1;

            for (int i = 1; i <= (n - 1) / 2; i++)
            {
                Console.Write(new string('-', leftRight));
                Console.Write('*');
                Console.Write(new string('-', mid));
                Console.Write('*');
                Console.Write(new string('-', leftRight));

                leftRight -= 1;
                mid += 2;
                Console.WriteLine();
            }

            if (n != 1 && n != 2)
            {
                leftRight = 1;
                mid -= 4;

                for (int i = 1; i < (n - 1) / 2; i++)
                {
                    Console.Write(new string('-', leftRight));
                    Console.Write('*');
                    Console.Write(new string('-', mid));
                    Console.Write('*');
                    Console.Write(new string('-', leftRight));

                    leftRight += 1;
                    mid -= 2;
                    Console.WriteLine();
                }

                Console.WriteLine("{0}{1}{0}", new string('-', leftRight),
                    new string('*', stars));
            }
        }
    }
}