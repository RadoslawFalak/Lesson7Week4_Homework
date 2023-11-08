using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7Week4
{
    internal class Exercise1
    {
        public static void IsEqual()
        {
            int a; 
            int b;

            string input = Console.ReadLine();
            int.TryParse(input, out a);
            input = Console.ReadLine();
            int.TryParse(input, out b);

            if (a == b)
            {
                Console.WriteLine(a + " i " + b + " sa rowne");
            }
            else
            {
                Console.WriteLine(a + " i " + b + " nie sa rowne");
            }

        }
            
    }
}
