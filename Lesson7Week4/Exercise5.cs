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
            else if (userAge >= 30)
            {
                Console.WriteLine("Mozesz zostac poslem lub senatorem");
            }
            else if (userAge >= 35)
            {
                Console.WriteLine("Mozesz zostac poslem, senatorem lub prezydentem");
            }
            else
            {
                Console.WriteLine("Nie możesz sprawować publicznej posla, senatora lub prezydenta");
            }
        }
    }
}
