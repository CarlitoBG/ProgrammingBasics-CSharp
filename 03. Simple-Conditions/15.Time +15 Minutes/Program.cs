using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time__15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var hour = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());

            var addedMinutes = minutes + 15;

            if (addedMinutes > 59)
            {
                hour += 1;
                addedMinutes -= 60;
            }

            if (hour > 23)
            {
                hour = 0;
            }

            if (addedMinutes < 10)
            {
                Console.WriteLine(hour + ":0" + addedMinutes);
            }
            else
            {
                Console.WriteLine("{0}:{1}", hour, addedMinutes);
            }
        }   
    }
}
