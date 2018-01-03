using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_Of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            string days = "";

            switch (input)
            {
                case 1: days = "Monday";
                    break;
                case 2: days = "Tuesday";
                    break;
                case 3: days = "Wednesday";
                    break;
                case 4: days = "Thursday";
                    break;
                case 5: days = "Friday";
                    break;
                case 6: days = "Saturday";
                    break;
                case 7: days = "Sunday";
                    break;
                default:
                    break;
            }
            if (input >= 1 && input <= 7)
            {
                Console.WriteLine(days);
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
