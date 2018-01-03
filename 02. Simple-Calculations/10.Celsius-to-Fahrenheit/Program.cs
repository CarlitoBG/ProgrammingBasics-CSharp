using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celsius_to_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            var Celsius = double.Parse(Console.ReadLine());
            var Fahrenheit = (Celsius * 9) / 5 + 32;

            Console.WriteLine(Math.Round(Fahrenheit, 2));
        }
    }
}
