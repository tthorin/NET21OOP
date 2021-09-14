using System;

namespace Kalender
{
    class Program
    {
        static void Main()
        {
            int month = 0;
            int year = DateTime.Now.Year;
            string[] monthNames =
            {
                "Januari",
                "Februari",
                "Mars",
                "April",
                "Maj",
                "Juni",
                "Juli",
                "Augusti",
                "September",
                "Oktober",
                "November",
                "December"
            };
            string[] dayNames =
            {
                "Måndag",
                "Tisdag",
                "Onsdag",
                "Torsdag",
                "Fredag",
                "Lördag",
                "Söndag"
            };
            Console.WriteLine("Kalender");
            
            while (month < 1 || month > 12)
            {
                month = AskForNumber("Ange månad (1-12): ");
            }

            DateTime startDate = new DateTime(year, month, 1);
            DayOfWeek weekDay = startDate.DayOfWeek;
            int startFrom = (int)weekDay;
            startFrom--;
            if (startFrom < 0) startFrom = 6;
            int monthLength = DateTime.DaysInMonth(year, month);

            int pageWidth = Console.WindowWidth - 1;
            int dayWidth = pageWidth / 7;
            int titleWidth = dayWidth * 7;
            dayWidth--;
            titleWidth--;
            //┌┐└┘─│├┤┬┴┼            
            string output = monthNames[month - 1] + " " + year + " ";
            output = output.PadLeft(titleWidth);

            Console.WriteLine("┌" + new string('─', titleWidth) + "┐");
            Console.WriteLine("│" + output + "│");

            string topCalendarSeparator = "";
            for (int i = 0; i < 7; i++)
            {
                if (i == 0) topCalendarSeparator += "├" + new string('─', dayWidth);
                else topCalendarSeparator += "┬" + new string('─', dayWidth);
            }
            topCalendarSeparator += "┤";

            string calendarSeparator = "";
            for (int i = 0; i < 7; i++)
            {
                if (i == 0) calendarSeparator += "├" + new string('─', dayWidth);
                else calendarSeparator += "┼" + new string('─', dayWidth);
            }
            calendarSeparator += "┤";

            string bottomCalendarSeparator = "";
            for (int i = 0; i < 7; i++)
            {
                if (i == 0) bottomCalendarSeparator += "└" + new string('─', dayWidth);
                else bottomCalendarSeparator += "┴" + new string('─', dayWidth);
            }
            bottomCalendarSeparator += "┘";

            Console.WriteLine(topCalendarSeparator);
            string dataline = "│(0)│(1)│(2)│(3)│(4)│(5)│(6)│";
            string dayLine = dataline;
            string infoLine = dataline;

            for (int i = 0; i < 7; i++)
            {
                string number = "(" + i + ")";
                output = " " + dayNames[i].PadRight(dayWidth);
                output = output.Substring(0, dayWidth);
                dayLine = dayLine.Replace(number, output);
            }
            Console.WriteLine(dayLine);
            Console.WriteLine(calendarSeparator);
            int pos = startFrom;
            dayLine = dataline;

            string emptyLine = new string(' ', dayWidth);
            for (int day = 0; day < startFrom; day++)
            {
                string number = $"({day})";
                dayLine = dayLine.Replace(number, emptyLine);
                infoLine = infoLine.Replace(number, emptyLine);
            }

            for (int day = 1; day <= monthLength; day++)
            {
                string number = $"({pos})";
                output = " " + day.ToString().PadRight(dayWidth).Substring(0, dayWidth - 1);
                dayLine = dayLine.Replace(number, output);
                infoLine = infoLine.Replace(number, emptyLine);
                pos++;
                if (pos > 6)
                {
                    pos = 0;
                    Console.WriteLine(dayLine);
                    Console.WriteLine(infoLine);
                    Console.WriteLine(infoLine);
                    if (day == monthLength) Console.WriteLine(bottomCalendarSeparator);
                    else Console.WriteLine(calendarSeparator);
                    dayLine = dataline;
                    infoLine = dataline;
                }
            }
            if (pos > 0)
            {
                for (int day = pos; day < 7; day++)
                {
                    string number = $"({day})";
                    dayLine = dayLine.Replace(number, emptyLine);
                    infoLine = infoLine.Replace(number, emptyLine);
                }
                Console.WriteLine(dayLine);
                Console.WriteLine(infoLine);
                Console.WriteLine(infoLine);
                Console.WriteLine(bottomCalendarSeparator);
            }
            Console.ReadKey();



        }
        static int AskForNumber(string question)
        {
            Console.Write(question);
            string input = Console.ReadLine();
            return CheckConversion(input);
        }

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
    }
}
