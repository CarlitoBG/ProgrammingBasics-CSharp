using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sleeping_Cat_Tom
{
    class Program
    {
        static void Main(string[] args)
        {
            var numRestDays = int.Parse(Console.ReadLine());
            var yearGameRate = 30000;
            var workGameTime = 63;
            var restGameTime = 127;
            var daysInAYear = 365;

            int currentGameRate = ((daysInAYear - numRestDays) * (workGameTime)) +
                ((numRestDays * restGameTime));
            int hours = Math.Abs((yearGameRate - currentGameRate) / 60);
            int minutes = Math.Abs((yearGameRate - currentGameRate) % 60);

            if (currentGameRate <= yearGameRate)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play",
                    hours, minutes);
            }
            else
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play",
                    hours, minutes);
            }
        }
    }
}
