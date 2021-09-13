using System;

namespace Langbord
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int bord = AskForNumber("Hur många bord har du? ");
            int platser = CalculateSeats(bord);
            Console.WriteLine($"Du får {platser} platser att sitta på om du sätter ihop {bord} bord.");
        }

        static int CalculateSeats(int tables)
        {
            int edgeSeats = 2;
            int sideSeats = 2;
            int totalSeats = (tables * sideSeats) + edgeSeats;
            return totalSeats;
        }
        static int AskForNumber (string question)
        {
            Console.Write(question);
            string input = Console.ReadLine();
            return CheckConversion(input);
        }

        static int CheckConversion (string stringToConvert)
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
