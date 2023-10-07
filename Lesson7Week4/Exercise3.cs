using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7Week4
{
    internal class Exercise3
    {
        public static void isPositiveOrNot() 
        {
            int userNumber;

            string input = Console.ReadLine();
            int.TryParse(input, out userNumber);

            if ( userNumber != 0 && userNumber > 0) 
            {
                Console.WriteLine(userNumber + " jest liczba dodatnia");
            }
            else if (userNumber != 0 && userNumber < 0)
            {
                Console.WriteLine(userNumber + " jest liczba ujemna");
            }
            else
            {
                Console.WriteLine("Podaj liczbe rozna od zera !");
            }
        }
       
    }
}
