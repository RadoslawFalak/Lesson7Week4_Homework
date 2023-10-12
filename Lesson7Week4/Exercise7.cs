using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7Week4
{
    internal class Exercise7
    {
        public static void greatestValue()
        {
            int a, b, c;

            string input = Console.ReadLine();
            bool intCheck= int.TryParse(input, out a);
            input = Console.ReadLine();
            intCheck = int.TryParse(input, out b);
            input = Console.ReadLine();
            intCheck = int.TryParse(input, out c);


            if ( intCheck != true)
            {
                Console.WriteLine("Musisz podac co najmniej jedna liczbe !");
            }
            else if ( a > b && a > c ) 
            {
                Console.WriteLine(a + " jest najwieksza z podanych");
            }
            else if ( b > c )
            {
                Console.WriteLine(b + " jest najwieksza z podanych");
            }
            else
            {
                Console.WriteLine(c + " jest najwieksza z podanych");
            }
        }
    }
}
