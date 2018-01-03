using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations_with_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n1 = int.Parse(Console.ReadLine());
            var n2 = int.Parse(Console.ReadLine());
            var oper = Console.ReadLine();

            var resultSummation = n1 + n2;
            var resultSubtraction = n1 - n2;
            var resultMultiplication = n1 * n2;
            var resultDivision = (double) n1 / n2;
            var resultMod = (double) n1 % n2;
            string evenOrOdd = "";

            switch (oper)
            {
                case "+":
                    if (resultSummation % 2 == 0)
                    {
                        evenOrOdd = "even";
                    }
                    else
                    {
                        evenOrOdd = "odd";
                    }
                    Console.WriteLine("{0} " + oper + " {1} = {2} - {3}", n1, n2,
                        resultSummation, evenOrOdd);
                    break;
                case "-":
                    if (resultSubtraction % 2 == 0)
                    {
                        evenOrOdd = "even";
                    }
                    else
                    {
                        evenOrOdd = "odd";
                    }
                    Console.WriteLine("{0} " + oper + " {1} = {2} - {3}", n1, n2,
                        resultSubtraction, evenOrOdd);
                    break;
                case "*":
                    if (resultMultiplication % 2 == 0)
                    {
                        evenOrOdd = "even";
                    }
                    else
                    {
                        evenOrOdd = "odd";
                    }
                    Console.WriteLine("{0} " + oper + " {1} = {2} - {3}", n1, n2,
                        resultMultiplication, evenOrOdd);
                    break;
                case "/":
                    if (n2 == 0)
                    {
                        Console.WriteLine("Cannot divide {0} by zero", n1);
                    }
                    else
                    {
                        Console.WriteLine("{0} " + oper + " {1} = {2:F2}", n1, n2,
                            resultDivision);
                    }
                    break;
                case "%":
                    if (n2 == 0)
                    {
                        Console.WriteLine("Cannot divide {0} by zero", n1);
                    }
                    else
                    {
                        Console.WriteLine("{0} " + oper + " {1} = {2}", n1, n2,
                            resultMod);
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
