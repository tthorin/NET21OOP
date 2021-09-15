namespace Kalender
{
    using System;
    class Program
    {
        static void Main()
        {   
            int year = 2021;
            int month = 9;
            Menu(year, month);
            Console.Clear();
        }

        //============start Method int AskForNumber(string question)=============================
        static int AskForNumber(string question)
        {
            Console.Write(question);
            string input = Console.ReadLine();
            return CheckConversion(input);
        }
        //============End Method int AskForNumber(string question)=============================

        //============Start Method int CheckConversion(string stringToConvert)=============================
        static int CheckConversion(string stringToConvert)
        {
            bool converted = false;
            int number = 0;
            do
            {
                converted = int.TryParse(stringToConvert, out number);
                if (!converted)
                {
                    Console.Write("Vänligen använd endast siffror: ");
                    stringToConvert = Console.ReadLine();
                }

            } while (!converted);
            return number;
        }
        //============End Method int CheckConversion(string stringToConvert)=============================

        //============Start Method void Menu (int year, int month)=============================
        static void Menu(int year, int month)
        {
            bool exit = false;
            do
            {
                CalendarPage.Print(year, month);
                Console.Write("Navigera år pgUp / PgDown, piltanger mellan månader eller X eller Esc. för att avsluta.");
                ConsoleKeyInfo input = Console.ReadKey(true);
                switch (input.Key)
                {
                    case ConsoleKey.LeftArrow:
                        month--;
                        break;
                    case ConsoleKey.DownArrow:
                        month--;
                        break;
                    case ConsoleKey.RightArrow:
                        month++;
                        break;
                    case ConsoleKey.UpArrow:
                        month++;
                        break;
                    case ConsoleKey.Escape:
                        exit = true;
                        break;
                    case ConsoleKey.X:
                        exit = true;
                        break;
                    case ConsoleKey.PageUp:
                        year++;
                        break;
                    case ConsoleKey.PageDown:
                        year--;
                        break;
                    default:
                        break;
                }
                if (month > 12)
                {
                    month = 1;
                    year++;
                }
                else if (month < 1)
                {
                    month = 12;
                    year--;
                }
            } while (!exit);
            return;
        }
        //============End Method void Menu (int year, int month)=============================
    }

}
