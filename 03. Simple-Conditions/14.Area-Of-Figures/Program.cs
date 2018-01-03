using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_Of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            var figure = Console.ReadLine();

            if (figure == "square")
            {
                var side = double.Parse(Console.ReadLine());
                var area = side * side;
                Console.WriteLine(Math.Round(area, 3));
            }
            else if (figure == "rectangle")
            {
                var lengthSide1 = double.Parse(Console.ReadLine());
                var lengthSide2 = double.Parse(Console.ReadLine());
                var area = lengthSide1 * lengthSide2;
                Console.WriteLine(Math.Round(area, 3));
            }
            else if (figure == "circle")
            {
                var radius = double.Parse(Console.ReadLine());
                var area = (Math.PI * (radius * radius));
                Console.WriteLine(Math.Round(area, 3));
            }
            else if (figure == "triangle")
            {
                var side = double.Parse(Console.ReadLine());
                var height = double.Parse(Console.ReadLine());
                var area = ((side * height) / 2);
                Console.WriteLine(Math.Round(area, 3));
            }
        }
    }
}
