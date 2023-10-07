using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7Week4
{
    internal class Exercise4
    {
        public static void IsItLeapYear()
        {
            int year;
            string input = Console.ReadLine();
            int.TryParse(input, out year);

            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                Console.WriteLine(year + " jest rokiem przestepnym");
            }
            else
            {
                Console.WriteLine(year + " nie jest rokiem przestepnym");
            }
        }
    }
}
