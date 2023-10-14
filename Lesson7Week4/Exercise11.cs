using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7Week4
{
    internal partial class Exercise11
    {
        public static void GradesNumberToText() 
        {
            int grade;
            string input = Console.ReadLine();
            int.TryParse(input, out grade);

            switch(grade)
            {
                case 1:
                    Console.WriteLine("Niedostatateczny");
                    break;
                case 2:
                    Console.WriteLine("Dopuszczajacy");
                    break;
                case 3:
                    Console.WriteLine("Dostateczny");
                    break;
                case 4:
                    Console.WriteLine("Dobry");
                    break;
                case 5:
                    Console.WriteLine("Bardzo dobry");
                    break;
                case 6:
                    Console.WriteLine("Celujacy");
                    break;
                default:
                    Console.WriteLine("Podaj cyfre z zakresu 1 - 6");
                    break;
            }
        }
    }
}
