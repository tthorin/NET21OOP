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
            //int year = 9999;
            //int month = 12;
            Menu(year, month);
            Console.Clear();
        }

        //============Start Method void Menu (int year, int month)=============================
        static void Menu(int year, int month)
        {
            Console.CursorVisible = false;
            bool exit = false;
            do
            {
                CheckYear(ref year, ref month);

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

        //============Start Method void CheckYear(ref int year, ref int month)=============================
        private static void CheckYear(ref int year, ref int month)
        {
            if (year < 1 || year > 9999)
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
            return;
        }
        //============End Method void CheckYear(ref int year, ref int month)=============================
    }

}
