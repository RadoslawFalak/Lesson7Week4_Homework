using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7Week4
{
    internal class Exercise8
    {
        public static void goToUniversity()
        {
            int mathResult, pchysicsResult, chemistryResult;

            string input = Console.ReadLine();
            int.TryParse(input, out mathResult);
            input = Console.ReadLine();
            int.TryParse(input, out pchysicsResult);
            input = Console.ReadLine();
            int.TryParse(input, out chemistryResult);

            if ( mathResult > 70 && pchysicsResult > 55 && chemistryResult > 45 || mathResult + pchysicsResult + chemistryResult > 180)
            {
                Console.WriteLine("Kandydat dopuszczony do rekrutacji");
            }
            else if ( mathResult + pchysicsResult > 150 || mathResult + chemistryResult > 150)
            {
                Console.WriteLine("Kandydat dopuszczony do rekrutacji");
            }
            else
            {
                Console.WriteLine("Kandydat nie dopuszczony do rekrutacji");
            }

        }
    }
}
