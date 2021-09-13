using System;

namespace Tagresa
{
    class Program
    {
        //=================start Main=================================
        static void Main(string[] args)
        {
            DateTime departure = new();
            DateTime arrival = new();

            do
            {
                departure = AskforTime("När är avresan?");
                arrival = AskforTime("När är ankomsten?");
                if (arrival < departure) Console.WriteLine("Du kan inte komma fram innan du har åkt, försök igen.\n");
            } while (arrival < departure);

            TimeSpan travelTime = arrival - departure;
            Console.WriteLine($"Resan tar {travelTime.Hours:00} timmar och {travelTime.Minutes:00} minuter.");
        }
        //=================end Main=================================

        //=================start AskForTime=================================
        static DateTime AskforTime(string question)
        {
            Console.Write($"{question} (Vänligen använd formatet hh:mm) ");
            string input = Console.ReadLine();
            DateTime givenTime = ConvertToDateTime(input);
            return givenTime;
        }
        //=================end AskForTime=================================

        //=================start ConvertToDateTime=================================
        static DateTime ConvertToDateTime(string input)
        {
            int whereToSplit = input.IndexOf(":");
            _ = int.TryParse(input.Substring(0, whereToSplit), out int hour);
            _ = int.TryParse(input.Substring(whereToSplit + 1), out int minute);
            DateTime today = DateTime.Now;
            DateTime conversionResult = new DateTime(today.Year, today.Month, today.Day, hour, minute, 0);
            return conversionResult;
        }
        //=================end ConvertToDateTime=================================
    }
}
