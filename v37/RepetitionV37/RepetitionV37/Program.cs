using System;

namespace RepetitionV37
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = AskForNumber("hepp:",10,100);
            Console.WriteLine(x);
        }

        static private int AskForNumber(string question = "Ange ett tal: ")
        {
            bool okNumber = false;
            int number = 0;
            Console.Write(question);
            string input = Console.ReadLine();
            do
            {
                okNumber = int.TryParse(input, out number);
                if (!okNumber)
                {
                    Console.Write($"Ange ett heltal, använd bara siffror: ");
                    input = Console.ReadLine();
                }
            } while (!okNumber);
            return number;
        }
        
        static private int AskForNumber(string question, int minVal, int maxVal)
        {
            bool okNumber = false;
            int number = 0;
            Console.Write(question);
            string input = Console.ReadLine();
            do
            {
                okNumber = int.TryParse(input, out number);
                if (!okNumber || number > maxVal || number < minVal)
                {
                    okNumber = false;
                    Console.Write($"Ange ett heltal mellan {minVal} och {maxVal}, använd bara siffror: ");
                    input = Console.ReadLine();
                }
            } while (!okNumber);
            return number;
        }

    }
}
