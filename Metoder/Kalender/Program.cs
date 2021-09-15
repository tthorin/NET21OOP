namespace Kalender
{
    using System;
    class Program
    {
        static void Main()
        {
            DateTime today = DateTime.Now;
            int year = today.Year;
            int month = today.Month;
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
            Console.CursorVisible = false;
            bool exit = false;
            do
            {
                if (year <1 || year > 9999)
                {   
                    if (year < 1)
                    {
                        year = 1;
                        month = 1;
                    }
                    else
                    {
                        year = 9999;
                        month = 12;
                    }
                    Console.Clear();
                    Console.WriteLine("Denna kalender kan bara visa mella år 1 och 9999");
                    Console.WriteLine("Tryck valfri knapp för att fortsätta.");
                    Console.ReadKey(true);
                }

                CalendarPage.Print(year, month);

                Console.Write("Navigera år pgUp / PgDown, piltanger mellan månader eller X eller Esc. för att avsluta.");
                ConsoleKeyInfo input = Console.ReadKey(true);
                switch (input.Key)
                {
                    case ConsoleKey.LeftArrow or ConsoleKey.DownArrow:
                        month--;
                        break;
                    case ConsoleKey.RightArrow or ConsoleKey.UpArrow:
                        month++;
                        break;
                    case ConsoleKey.Escape or ConsoleKey.X:
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

            Console.CursorVisible = true;
            return;
        }
        //============End Method void Menu (int year, int month)=============================
    }

}
