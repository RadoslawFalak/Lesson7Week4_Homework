using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7Week4
{
    internal class IsItANumber
    {
        public static int CheckInput(string input)
        {
            int value = 0;
            bool isValid = int.TryParse(input, out value);
            while (isValid == false)
            {
                Console.WriteLine("Podaj liczbe.");
                input = Console.ReadLine();
                isValid = int.TryParse(input, out value);
                if (isValid == true)
                {
                    break;
                }
            }
            return value;
        }
    }
}

