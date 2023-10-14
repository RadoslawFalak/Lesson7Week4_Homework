using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7Week4
{
    internal class Exercise10
    {
        public static void Triangle() 
        {
            int a, b, c;

            string input = Console.ReadLine();
            int.TryParse(input, out a);
            input = Console.ReadLine();
            int.TryParse(input, out b);
            input = Console.ReadLine();
            int.TryParse(input, out c);

            if ( a + b > c )
            {
                Console.WriteLine("Można zbudować trójkąt");
            }
            else
            {
                Console.WriteLine("Nie można zbudować trójkąta");
            }

        }
    }
}
