﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            var score = int.Parse(Console.ReadLine());
            var bonusScore = 0d;

            if (score <= 100)
            {
                bonusScore = bonusScore + 5;
            }
            else if (score < 1000)
            {
                bonusScore = score * 0.2;
            }
            else if (score > 1000)
            {
                bonusScore = score * 0.1;
            }

            if (score % 2 == 0)
            {
                bonusScore = bonusScore + 1;
            }

            if (score % 10 == 5)
            {
                bonusScore = bonusScore + 2;
            }

            Console.WriteLine(bonusScore);
            Console.WriteLine(score + bonusScore);
        }
    }
}
