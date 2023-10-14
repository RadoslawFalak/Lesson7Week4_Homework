using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7Week4
{
    internal class Exercise13
    {
        public static void SimplyCalculator()
        {
            int firstValue, secondValue, choice;

            Console.Write("Podaj pierwsza liczbe: ");
            string input = Console.ReadLine();
            int.TryParse(input, out firstValue);
            Console.Write("Podaj druga liczbe: ");
            input = Console.ReadLine();
            int.TryParse(input, out secondValue);

            Console.WriteLine("Podaj numer operacji do wykonania");
            Console.WriteLine("1. Dodawanie \r\n2. Odejmowanie \r\n3. Mnozenie \r\n4. Dzielenie");

            input = Console.ReadLine();
            int.TryParse(input, out choice);
            Console.Write("Twoj wynik to: ");

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Twoj wynik to: " + firstValue + secondValue);
                    break;
                case 2:
                    Console.WriteLine(firstValue - secondValue);
                    break;
                case 3:
                    Console.WriteLine(firstValue * secondValue);
                    break;
                case 4:
                    if (firstValue != 0 && secondValue != 0)
                    {
                        Console.WriteLine(firstValue / secondValue);
                    }
                    else if (firstValue == 0 || secondValue == 0)
                    {
                        Console.WriteLine("Nie dzielimy przez 0");
                    }
                    break;
                default:
                    Console.WriteLine("Wybierz numer opercaji z zakresu 1 - 4.");
                    break;
            }
        }
    }
}
