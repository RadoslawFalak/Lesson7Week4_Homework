using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7Week4
{
    internal class Exercise5
    {
        public static void CanBePresident() 
        {
            int userAge;
            string input = Console.ReadLine();
            int.TryParse(input, out userAge);

            if ( userAge >= 21)
            {
                Console.WriteLine("Mozesz zostac poslem");
            }
            else if ( userAge < 21 && userAge > 0)
            {
                int a = 21 - userAge;
                Console.WriteLine("Zeby zostac poslem brakuje Ci " + a);
            }
            else 
            {
                Console.WriteLine("Bledny format danych");
            }
        }
    }
}
