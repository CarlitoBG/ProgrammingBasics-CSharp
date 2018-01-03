using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace On_Time_For_The_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            var examHour = int.Parse(Console.ReadLine());
            var examMinutes = int.Parse(Console.ReadLine());
            var arrivalHour = int.Parse(Console.ReadLine());
            var arrivalMinutes = int.Parse(Console.ReadLine());

            var examTime = examHour * 60 + examMinutes;
            var arrivalTime = arrivalHour * 60 + arrivalMinutes;
            var timeDifference = arrivalTime - examTime;

            if (timeDifference < -30)
            {
                Console.WriteLine("Early");
            }
            else if (timeDifference <= 0)
            {
                Console.WriteLine("On time");
            }
            else
            {
                Console.WriteLine("Late");
            }

            if (timeDifference != 0)
            {
                var hours = Math.Abs(timeDifference / 60);
                var minutes = Math.Abs(timeDifference % 60);

                if (hours > 0)
                {
                    if (minutes < 10)
                    {
                        Console.Write(hours + ":0" + minutes + " hours");
                    }
                    else
                    {
                        Console.Write(hours + ":" + minutes + " hours");
                    }
                }
                else
                {
                    Console.Write(minutes + " minutes");
                }

                if (timeDifference < 0)
                {
                    Console.WriteLine(" before the start");
                }
                else
                {
                    Console.WriteLine(" after the start");
                }
            }
         }
    }
}
