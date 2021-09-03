using System;

namespace if_ovning_1
{
    class Program
    {
        static void Main()
        {
            int sidaA = 0;
            int sidaB = 0;
            int sidaC = 0;
            int omkrets = 0;
            string input = "";

            Console.Write("Ange sida A: ");
            input = Console.ReadLine();
            sidaA = StringToInt(input);

            Console.Write("Ange sida B: ");
            input = Console.ReadLine();
            sidaB = StringToInt(input);

            Console.Write("Ange sida C: ");
            input = Console.ReadLine();
            sidaC = StringToInt(input);

        }

        static int StringToInt(string strToConvert)
        {
            int intValue = 0;
            bool notConverted = true;

            while (notConverted)
            {
                try
                {
                    intValue = int.Parse(strToConvert);
                    notConverted = false;
                }
                catch
                {
                    Console.Write("Vänligen använd endast siffror när du anger värdet: ");
                    strToConvert = Console.ReadLine();
                }
            }
            return intValue;
        }
    }
}
