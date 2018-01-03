using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOnSegment
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = int.Parse(Console.ReadLine());
            var second = int.Parse(Console.ReadLine());
            var point = int.Parse(Console.ReadLine());

            var leftPoint = Math.Min(first, second);
            var rightPoint = Math.Max(first, second);

            var distanceFromLeftPoint = Math.Abs(leftPoint - point);
            var distanceFromRightPoint = Math.Abs(rightPoint - point); 

            if (point >= leftPoint && point <= rightPoint)
            {
                Console.WriteLine("in");
                Console.WriteLine(Math.Min(distanceFromLeftPoint, distanceFromRightPoint));
            }
            else 
            {
                Console.WriteLine("out");
                Console.WriteLine(Math.Min(distanceFromLeftPoint, distanceFromRightPoint));
            }
        }
    }
}
