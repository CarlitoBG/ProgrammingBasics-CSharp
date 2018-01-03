using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreviousExamTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            var pricePerKilosVegs = decimal.Parse(Console.ReadLine());
            var pricePerKilosFruits = decimal.Parse(Console.ReadLine());
            var totalKilosVegs = int.Parse(Console.ReadLine());
            var totalKilosFruits = int.Parse(Console.ReadLine());

            decimal profit = ((pricePerKilosVegs * totalKilosVegs) +
                (pricePerKilosFruits * totalKilosFruits)) / 1.94m;

            Console.WriteLine(profit);
        }
    }
}
