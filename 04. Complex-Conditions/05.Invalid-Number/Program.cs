using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invalid_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            var inRange = (input >= 100 && input <= 200) || input == 0;

            if (!inRange)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
