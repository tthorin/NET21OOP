namespace Kalender
{
    using System;
    //============start Class CalendarPage=============================
    static class CalendarPage
    {
        static int Year;
        static string Month;
        static string[] MonthNames =
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
        static string[] DayNames =
        {
                "Måndag",
                "Tisdag",
                "Onsdag",
                "Torsdag",
                "Fredag",
                "Lördag",
                "Söndag"
            };
        static int StartFrom;
        static int MonthLength;
        static int DayWidth;
        static int TitleWidth;
        static string Dataline = "│(0)│(1)│(2)│(3)│(4)│(5)│(6)│";
        static string Separator;
        static string BottomSeparator;
        static int Pos;

        static void SetUpPage(int year, int month)
        {
            Year = year;
            Month = MonthNames[month - 1];
            DateTime startDate = new DateTime(year, month, 1);
            DayOfWeek weekDay = startDate.DayOfWeek;
            StartFrom = (int)weekDay;
            StartFrom--;
            if (StartFrom < 0) StartFrom = 6;
            MonthLength = DateTime.DaysInMonth(year, month);
            int pageWidth = Console.WindowWidth - 1;
            DayWidth = pageWidth / 7;
            TitleWidth = DayWidth * 7;
            DayWidth--;
            TitleWidth--;
            Separator = SetupSeparator();
            BottomSeparator = SetupBottomSeparator();
        }
        static string SetupSeparator()
        {
            string separator = "";
            for (int i = 0; i < 7; i++)
            {
                if (i == 0) separator += "├" + new string('─', DayWidth);
                else separator += "┼" + new string('─', DayWidth);
            }
            separator += "┤";
            return separator;
        }
        static string SetupBottomSeparator()
        {
            string bottomCalendarSeparator = "";
            for (int i = 0; i < 7; i++)
            {
                if (i == 0) bottomCalendarSeparator += "└" + new string('─', DayWidth);
                else bottomCalendarSeparator += "┴" + new string('─', DayWidth);
            }
            bottomCalendarSeparator += "┘";
            return bottomCalendarSeparator;
        }
        static public void Print(int year, int month)
        {
            SetUpPage(year, month);
            Console.Clear();
            Pos = StartFrom;
            PrintTitle();
            PrintTopSeparator();
            PrintDayBar();
            string firstRow = PrepareFirstRow();
            string lastRow = PrintMainPart(firstRow);
            if (Pos > 0) PrintLastRow(lastRow);
        }
        static void PrintTitle()
        {
            string output = Month + " " + Year + " ";
            output = output.PadLeft(TitleWidth);

            Console.WriteLine("┌" + new string('─', TitleWidth) + "┐");
            Console.WriteLine("│" + output + "│");
            return;
        }
        static void PrintTopSeparator()
        {
            string topCalendarSeparator = "";
            for (int i = 0; i < 7; i++)
            {
                if (i == 0) topCalendarSeparator += "├" + new string('─', DayWidth);
                else topCalendarSeparator += "┬" + new string('─', DayWidth);
            }
            topCalendarSeparator += "┤";
            Console.WriteLine(topCalendarSeparator);
            return;
        }
        static void PrintDayBar()
        {
            string dayLine = Dataline;
            for (int i = 0; i < 7; i++)
            {
                string number = "(" + i + ")";
                string output = " " + DayNames[i].PadRight(DayWidth);
                output = output.Substring(0, DayWidth);
                dayLine = dayLine.Replace(number, output);
            }
            Console.WriteLine(dayLine);
            Console.WriteLine(Separator);
        }
        static string PrepareFirstRow()
        {
            string firstRow = Dataline;
            string emptyLine = new(' ', DayWidth);
            for (int day = 0; day < StartFrom; day++)
            {
                string number = $"({day})";
                firstRow = firstRow.Replace(number, emptyLine);
            }
            return firstRow;
        }
        static string PrintMainPart(string firstRow)
        {
            string emptyLine = new(' ', DayWidth);
            string dayLine = firstRow;
            string infoLine = firstRow;
            for (int day = 1; day <= MonthLength; day++)
            {
                string number = $"({Pos})";
                string output = " " + day.ToString().PadRight(DayWidth).Substring(0, DayWidth - 1);
                dayLine = dayLine.Replace(number, output);
                infoLine = infoLine.Replace(number, emptyLine);
                Pos++;
                if (Pos > 6)
                {
                    Pos = 0;
                    Console.WriteLine(dayLine);
                    Console.WriteLine(infoLine);
                    Console.WriteLine(infoLine);
                    if (day == MonthLength) Console.WriteLine(BottomSeparator);
                    else Console.WriteLine(Separator);
                    dayLine = Dataline;
                    infoLine = Dataline;
                }
            }
            return dayLine;
        }
        static void PrintLastRow(string lastRow)
        {
            string emptyLine = new(' ', DayWidth);
            string dayLine = lastRow;
            string infoLine = Dataline;
            for (int day = 0; day < 7; day++)
            {
                string number = $"({day})";
                if (day >= Pos) dayLine = dayLine.Replace(number, emptyLine);
                infoLine = infoLine.Replace(number, emptyLine);
            }
            Console.WriteLine(dayLine);
            Console.WriteLine(infoLine);
            Console.WriteLine(infoLine);
            Console.WriteLine(BottomSeparator);
        }
    }
    //============End Class CalendarPage=============================
}
