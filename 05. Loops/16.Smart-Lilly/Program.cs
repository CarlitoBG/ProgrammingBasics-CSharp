using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Lilly
{
    class Program
    {
        static void Main(string[] args)
        {
            var ageLilly = int.Parse(Console.ReadLine());
            var washingMachinePrice = decimal.Parse(Console.ReadLine());
            var toySinglePrice = int.Parse(Console.ReadLine());

            var toyCount = 0;
            var money = 0m;
            var brotherMoney = 0m;

            for (int i = 1; i <= ageLilly; i++)
            {
                if (i % 2 != 0)
                {
                    toyCount += 1;
                }
                else if (i % 2 == 0)
                {
                    money += ((i * 10) / 2);
                    brotherMoney += 1; 
                }
            }

            decimal soldToysMoney = toyCount * toySinglePrice;
            decimal savedMoney = money + soldToysMoney - brotherMoney;

            if (savedMoney >= washingMachinePrice)
            {
                Console.WriteLine("Yes! {0:f2}", savedMoney - washingMachinePrice);
            }
            else
            {
                Console.WriteLine("No! {0:f2}", washingMachinePrice - savedMoney);
            }
        }
    }
}
