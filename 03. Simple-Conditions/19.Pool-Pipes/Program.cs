using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_Pipes
{
    class Program
    {
        static void Main(string[] args)
        {
            var volumePool = int.Parse(Console.ReadLine());
            var debitPipe1 = int.Parse(Console.ReadLine());
            var debitPipe2 = int.Parse(Console.ReadLine());
            var hours = double.Parse(Console.ReadLine());

            double currentVolume = ((debitPipe1 * hours) + (debitPipe2 * hours));
            double percentFull = Math.Truncate((currentVolume / volumePool) * 100);
            double pipe1 = Math.Truncate(((debitPipe1 * hours) / currentVolume) * 100);
            double pipe2 = Math.Truncate(((debitPipe2 * hours) / currentVolume) * 100);

            if (currentVolume <= volumePool)
            {
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.",
                percentFull, pipe1, pipe2);
            }
            else 
            {
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.",
                    hours, currentVolume - volumePool);
            }
        }
    }
}
