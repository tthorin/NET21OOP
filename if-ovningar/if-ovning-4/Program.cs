using System;

namespace if_ovning_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 0;
            float dogAge = 0;
            float catAge = 0;
            string input = "";

            Console.Write("Hur gammal är du? ");
            input = Console.ReadLine();
            age = InputToInt(input);

            //Hundar följer formeln: Människoår = 16 * ln(hundår) + 31
            dogAge = 16 * (float)Math.Round(Math.Log(age) + 31, 2);
            if (age == 1)
            {
                catAge = 14;
            }
            else if (age == 2)
            {
                catAge = 24;
            }
            else
            {
                catAge = 24 + ((age - 2) * 4);
            }
            Console.WriteLine("Hundår: "+ dogAge);
            Console.WriteLine("Kattår: " + catAge);
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
