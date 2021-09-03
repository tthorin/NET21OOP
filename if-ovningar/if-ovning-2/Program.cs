using System;

namespace if_ovning_2
{
    class Program
    {
        static void Main()
        {
            Console.Write("Hur gammal är du? ");
            string input = Console.ReadLine();
            int age = InputToInt(input);

            if (age > 14)
            {
                Console.WriteLine("Du får EU moped.");
                if (age > 17)
                {
                    Console.WriteLine("Du får personbil.");
                    if (age > 20)
                    {
                        Console.WriteLine("Du får tung lastbil.");
                        if (age > 23)
                        {
                            Console.WriteLine("Du får buss.");
                        }
                    }
                }
            }


        }

        static int InputToInt (string input)
        {
            bool converted = false;
            int intValue = 0;
            while (!converted)
            {
                converted = int.TryParse(input, out intValue);

                if(converted && intValue<1)
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
    }
}
