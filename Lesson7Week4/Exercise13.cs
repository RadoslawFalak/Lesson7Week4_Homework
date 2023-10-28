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
            firstValue = IsItANumber.CheckInput(input); //sprawdza czy podana wartosc jest liczba i wymusza podanie liczby
            Console.Write("Podaj druga liczbe: ");
            input = Console.ReadLine();
            secondValue = IsItANumber.CheckInput(input);
            Console.WriteLine("Podaj numer operacji do wykonania");
            Console.WriteLine("1. Dodawanie \r\n2. Odejmowanie \r\n3. Mnozenie \r\n4. Dzielenie");

            input = Console.ReadLine();
            int.TryParse(input, out choice);
            Console.Write("Twoj wynik to: ");

            switch (choice)
            {
                case 1:
                    Console.WriteLine(firstValue + secondValue);
                    break;
                case 2:
                    Console.WriteLine(firstValue - secondValue);
                    break;
                case 3:
                    Console.WriteLine(firstValue * secondValue);
                    break;
                case 4:
                    if (secondValue != 0)
                    {
                        Console.WriteLine(firstValue / secondValue);
                    }
                    else if (secondValue == 0)
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
