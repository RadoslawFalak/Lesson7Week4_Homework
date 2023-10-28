using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7Week4
{
    internal class Exercise6
    {
        public static void HowHight()
        {
            int userHight;
            string input = Console.ReadLine();
            int.TryParse(input, out userHight); 

            if (userHight  < 120 && userHight > 50) 
            {
                Console.WriteLine("Jestes dzieckiem");
            }
            else if (userHight >= 120 && userHight <= 140)
            {
                Console.WriteLine("Jestes krasnoludem");
            }
            else if (userHight > 140 && userHight <= 180)
            {
                Console.WriteLine("Jestes czlowiekiem");
            }
            else if (userHight > 180 && userHight <= 240)
            {
                Console.WriteLine("Jesteś wielkoludem");
            }
            else if (userHight > 240 && userHight <= 350)
            {
                Console.WriteLine("Jestes trolem");
            }
            else
            {
                Console.WriteLine("Bledne dane");
            }
        }
    }
}