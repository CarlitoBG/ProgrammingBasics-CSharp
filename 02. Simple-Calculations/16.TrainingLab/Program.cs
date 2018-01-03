using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            double corridorWidth = 1.0;
            double deskHeight = 1.2;
            double deskWidth = 0.7;
            double desksPerRow;
            double desksPerColumn;
            
            var h = double.Parse(Console.ReadLine());
            var w = double.Parse(Console.ReadLine());

            desksPerRow = Math.Floor((w - corridorWidth) / deskWidth);
            desksPerColumn = Math.Floor(h / deskHeight);

            Console.WriteLine((desksPerRow * desksPerColumn) - 3);
        }
    }
}
