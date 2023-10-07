using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7Week4
{
    internal class Exercise2
    {
        public static void isEvenOrNot()
        {
            int userNumber;

            string input = Console.ReadLine();
            int.TryParse(input, out userNumber);

            if ( userNumber != 0 && userNumber %2 == 0 )
            {
                Console.WriteLine(userNumber + " jest liczba parzysta");
            }
            else if ( userNumber == 0 )
            {
                Console.WriteLine("Podaj liczbe rozna od zera");
            }
            else 
            {
                Console.WriteLine(userNumber + " jest liczba nieparzysta");
            }

        }
    }
}
