using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            var typeOfProjection = Console.ReadLine();
            var rows = int.Parse(Console.ReadLine());
            var columns = int.Parse(Console.ReadLine());
            var income = 0m;

            if (typeOfProjection == "Premiere")
            {
                income = (rows * columns) * 12m;
            }
            else if (typeOfProjection == "Normal")
            {
                income = (rows * columns) * 7.50m;
            }
            else if (typeOfProjection == "Discount")
            {
                income = (rows * columns) * 5.00m;
            }

            Console.WriteLine("{0:f2}", income);

        }
    }
}
