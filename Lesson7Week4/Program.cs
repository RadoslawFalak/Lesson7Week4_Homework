using Lesson7Week4;

internal class Program
{
    private static void Main(string[] args)
    {
        bool start = true;
        while (start)
        {
            Console.WriteLine("Podaj numer zadania ktore chcesz sprawdzic:                                        |\n\r" +
                "1. Podaj dwie zmienne int i sprawdz czy sa sobie rowne.                            |\n\r" +
                "2. Podaj liczbe i sprawdz czy jest parzysta.                                       |\n\r" +
                "3. Podaj liczbe i sprawdz czy jest parzysta czy nieparzysta.                       |\n\r" +
                "4. Podaj rok i sprawdz czy jest rokiem przestepnym.                                |\n\r" +
                "5. Podaj wiek i sprawdz czy mozesz zostac poslem.                                  |\n\r" +
                "6. Podaj wzrost i sprawdz kim jestes.                                              |\n\r" +
                "7. Podaj trzy liczby i sprawdz ktora jest najwieksza.                              |\n\r" +
                "8. Podaj wyniki z trzech egzaminow zeby sprawdzic czy dostales sie na studia.      |\n\r" +
                "9. Podaj temerature.                                                               |\n\r" +
                "10. Podaj trzy dlugosci odcinkow zeby sprawdzic czy mozna z nich zbudowac trojkat. |\n\r" +
                "11. Podaj ocene od 1 do 6.                                                         |\n\r" +
                "12. Podaj numer dnia tygodnia zeby wyswietlic jego nazwe.                          |\n\r" +
                "13. Podstawowy kalkulator.                                                         |\n\r" +
                "14. -----EXIT----                                                                  |\n\r" +
                "___________________________________________________________________________________|");
            string input = Console.ReadLine();
            int choice = IsItANumber.CheckInput(input);

            switch (choice)
            {
                case 1:
                    Exercise1.IsEqual();
                    break;
                case 2:
                    Exercise2.IsEvenOrNot();
                    break;
                case 3:
                    Exercise3.IsPositiveOrNot();
                    break;
                case 4:
                    Exercise4.IsItLeapYear();
                    break;
                case 5:
                    Exercise5.CanBePresident();
                    break;
                case 6:
                    Exercise6.HowHight();
                    break;
                case 7:
                    Exercise7.GreatestValue();
                    break;
                case 8:
                    Exercise8.GoToUniversity();
                    break;
                case 9:
                    Exercise9.Temperature();
                    break;
                case 10:
                    Exercise10.Triangle();
                    break;
                case 11:
                    Exercise11.GradesNumberToText();
                    break;
                case 12:
                    Exercise12.NameDayOfTheWeek();
                    break;
                case 13:
                    Exercise13.SimplyCalculator();
                    break;
                case 14:
                    start = false;
                    break;
                default:
                    Console.WriteLine("Podaj liczbe z zakresu 1 - 13");
                    break;
            }
            Console.WriteLine("____________________________________________________________________________________");
        }
    }
}