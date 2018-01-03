using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            var yearType = Console.ReadLine();
            var numHolidays = int.Parse(Console.ReadLine());
            var weeksReturnHome = int.Parse(Console.ReadLine());

            var volleyballWeeks = 48;
            var weekendsSofia = (volleyballWeeks - weeksReturnHome) *
                (3.0 / 4);
            var holidaySofiaGames = numHolidays * (2.0 / 3);
            var totalGames = (weekendsSofia + holidaySofiaGames + weeksReturnHome);

            if (yearType == "leap")
            {
                totalGames = totalGames + (totalGames * 0.15);
            }
            else if (yearType == "normal")
            {
                
            }

            Console.WriteLine(Math.Truncate(totalGames));

        }
    }
}
