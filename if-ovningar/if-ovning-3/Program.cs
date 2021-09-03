using System;

namespace if_ovning_3
{
    class Program
    {
        static int InputToInt(string input)
        {
            bool converted = false;
            int intValue = 0;
            while (!converted)
            {
                converted = int.TryParse(input, out intValue);

                if (converted && intValue < 1)
                {
                    converted = false;
                    Console.Write("Vänligen ange ett tal över 0: ");
                    input = Console.ReadLine();
                }
                else if (!converted)
                {
                    Console.Write("Vänligen använd bara siffror och ange ett positivt tal: ");
                    input = Console.ReadLine();
                }
            }
            return intValue;
        }

        static void Main()
        {
            Random rng = new Random();
            int hemligtTal = rng.Next(1, 101);
            bool secretNotFound = true;
            string input = "";
            int guess = 0;
            int gissningar = 0;

            Console.WriteLine("Hello World!");

            while(secretNotFound)
            {
                Console.Write("Gissa på ett tal mellan 1 och 100: ");
                input = Console.ReadLine();
                guess = InputToInt(input);
                gissningar++;

                if (guess > hemligtTal)
                    Console.WriteLine("Du gissade för högt, förösk igen.");
                else if (guess < hemligtTal)
                    Console.WriteLine("Du gissade för lågt. försök igen.");
                else
                {
                    Console.WriteLine($"Du gissade rätt. GRATTIS!! Du klarade det på {gissningar} försök.");
                    secretNotFound = false;
                }

            }
        }
    }
}
