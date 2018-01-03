using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repair_Of_Tiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var sideOfSquare = double.Parse(Console.ReadLine());
            var widthOfTile = double.Parse(Console.ReadLine());
            var lengthOfTile = double.Parse(Console.ReadLine());
            var widthOfBench = double.Parse(Console.ReadLine());
            var lengthOfBench = double.Parse(Console.ReadLine());

            double timeOfRepairSingleTile = 0.2;

            var areaOfSquare = (sideOfSquare * sideOfSquare);
            var areaOfTile = (widthOfTile * lengthOfTile);
            var areaOfBench = (widthOfBench * lengthOfBench);

            Console.WriteLine((areaOfSquare - areaOfBench) / areaOfTile);
            Console.WriteLine(((areaOfSquare - areaOfBench) / areaOfTile) *
                timeOfRepairSingleTile);
        }
    }
}
