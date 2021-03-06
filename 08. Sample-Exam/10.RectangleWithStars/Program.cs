﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleWithStars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine(new string('%', n * 2));

            var rows = n;

            if (n % 2 == 0)
            {
                rows--;
            }

            for (int i = 0; i < rows; i++)
            {
                if (i == rows / 2)
                {
                    Console.WriteLine("%{0}**{0}%", new string(' ', n - 2));
                }
                else
                {
                    Console.WriteLine("%{0}%", new string(' ', (n * 2) - 2));
                }
            }

            Console.WriteLine(new string('%', n * 2));
        }
    }
}
