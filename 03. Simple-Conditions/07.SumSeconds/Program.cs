using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var timeContestant1 = int.Parse(Console.ReadLine());
            var timeContestant2 = int.Parse(Console.ReadLine());
            var timeContestant3 = int.Parse(Console.ReadLine());

            var sumTime = timeContestant1 + timeContestant2 + timeContestant3;
            var minutes = sumTime / 60;
            var seconds = sumTime % 60;

            Console.Write(minutes);

            if (seconds < 10)
            {
                Console.WriteLine(":0" + seconds);
            }
            else
            {
                Console.WriteLine(":" + seconds);
            }
        }
    }
}
