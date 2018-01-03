using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1000_Days_After_Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = Console.ReadLine();
            string format = "dd-MM-yyyy";
            DateTime birthday = DateTime.ParseExact(value, format,
                CultureInfo.InvariantCulture);
            Console.WriteLine(birthday.AddDays(999).ToString(format));
        }
    }
}
