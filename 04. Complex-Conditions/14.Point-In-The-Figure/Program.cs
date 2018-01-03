using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_In_The_Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = int.Parse(Console.ReadLine());
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());

            var insideBottomRectangle = (x > 0 && x < h * 3) && (y > 0 && y < h);
            var insideTopRectangle = (x > h && x < h * 2) && (y > h && y < h * 4);
            var onCommonSide = (x > h && x < h * 2 && y == h);
            var outsideBottomRectangle = (x < 0 || x > h * 3) || (y < 0 || y > h);
            var outsideTopRectangle = (x < h || x > h * 2) || (y < 0 || y > h * 4);

            if (insideBottomRectangle || insideTopRectangle || onCommonSide)
            {
                Console.WriteLine("inside");
            }
            else if (outsideBottomRectangle && outsideTopRectangle)
            {
                Console.WriteLine("outside");
            }
            else
            {
                Console.WriteLine("border");
            }
        }
    }
}
