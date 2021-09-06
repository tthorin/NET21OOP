using System;

namespace NET21_inlämning1
{
    class Program
    {
        static void Main()
        {
            int bet = 0;
        }
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
    }
}
