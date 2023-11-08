using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7Week4
{
    internal class Exercise2
    {
        public static void IsEvenOrNot()
        {
            int userNumber;
            string input = Console.ReadLine();
            int.TryParse(input, out userNumber);

            if (userNumber %2 == 0)
            {
                Console.WriteLine(userNumber + " jest liczba parzysta");
            }           
            else 
            {
                Console.WriteLine(userNumber + " jest liczba nieparzysta");
            }
        }
    }
}
