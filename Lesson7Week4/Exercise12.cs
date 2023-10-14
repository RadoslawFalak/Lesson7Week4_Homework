using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7Week4
{
    internal class Exercise12
    {
        enum DaysOfTheWeek
        {
            Poniedzialek = 1,
            Wtorek,
            Sroda,
            Czwartek,
            Piatek,
            Sobota,
            Niedziela
        }
        public static void NameDayOfTheWeek()
        {
            int dayNumber;
            string input = Console.ReadLine();
            int.TryParse(input, out dayNumber);

            if (dayNumber >= 1 && dayNumber <= 7)
            {
                Console.WriteLine((DaysOfTheWeek)dayNumber);
            }
            else
            {
                Console.WriteLine("Podaj cyfre z zakresu 1 - 7");
            }
        }
    }
}
