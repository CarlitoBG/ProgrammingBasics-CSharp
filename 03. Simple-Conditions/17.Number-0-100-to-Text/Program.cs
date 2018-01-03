using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_0_100_to_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var firstDigit = num / 10;  // взема целочислената част - примерно 25 / 10 = 2
            var secondDigit = num % 10; // остатъка при деление на 10 - примерно 25 % 10= 5
            var bothDigits = num; // Задаваме числото иначе няма да работи

            string secondWord = "";
            string firstWord = "";
            string bothWords = "";

            //Console.WriteLine(secondDigit);

            switch (secondDigit)
            {
                case 0: secondWord = "zero"; break;
                case 1: secondWord = "one"; break;
                case 2: secondWord = "two"; break;
                case 3: secondWord = "three"; break;
                case 4: secondWord = "four"; break;
                case 5: secondWord = "five"; break;
                case 6: secondWord = "six"; break;
                case 7: secondWord = "seven"; break;
                case 8: secondWord = "eight"; break;
                case 9: secondWord = "nine"; break;
                default: break;
            }
            switch (firstDigit)
            {
                case 2: firstWord = "twenty"; break;
                case 3: firstWord = "thirty"; break;
                case 4: firstWord = "fourty"; break;
                case 5: firstWord = "fifty"; break;
                case 6: firstWord = "sixty"; break;
                case 7: firstWord = "seventy"; break;
                case 8: firstWord = "eighty"; break;
                case 9: firstWord = "ninety"; break;
                default: break;
            }
            switch (bothDigits)
            {
                case 10: bothWords = "ten"; break;
                case 11: bothWords = "eleven"; break;
                case 12: bothWords = "twelve"; break;
                case 13: bothWords = "thirteen"; break;
                case 14: bothWords = "fourteen"; break;
                case 15: bothWords = "fifteen"; break;
                case 16: bothWords = "sixteen"; break;
                case 17: bothWords = "seventeen"; break;
                case 18: bothWords = "eighteen"; break;
                case 19: bothWords = "nineteen"; break;
                default: break;
            }

            if (num >= 0 && num <= 9)
            {
                Console.WriteLine(secondWord);
            }
            else if (num >= 10 && num <= 19)
            {
                Console.WriteLine(bothWords);
            }
            else if (num >= 20 && num <= 100)
            {
                if (num % 10 == 0 && num != 10 && num != 100) // този израз описва числата 20,30,40,50,60,70,80,90 (без 10 и 100)
                {
                    Console.WriteLine(firstWord);
                }
                else if (num == 100)
                {
                    Console.WriteLine("one hundred");
                }
                else
                {
                    Console.WriteLine(firstWord + "-" + secondWord);
                }

            }
            else
            {
                Console.WriteLine("invalid number");
            }
        }
    }
}
