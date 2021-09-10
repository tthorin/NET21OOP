namespace ovn8_SökNummerIListor
{
    using System;
    using System.Collections.Generic;
    class Program
    {
        static void Main()
        {
            Random rng = new();
            List<int> listOfNumbers = new();

            for (int i = 0; i < 10; i++)
            {
                listOfNumbers.Add(rng.Next(1, 101));
            }

            foreach (var item in listOfNumbers)
            {
                Console.WriteLine(item);
            }

            int number = GetIntInput("Ange nummer att söka efter: ");

            int searchResult = listOfNumbers.IndexOf(number);
            if (searchResult > -1)
                Console.WriteLine($"{number} hittades på index {searchResult}.");
            else
                Console.WriteLine("Numret kunde inte hittas.");

            for (int i = 0; i < listOfNumbers.Count; i++)
            {
                if (listOfNumbers[i] > number)
                    Console.WriteLine(listOfNumbers[i] + " är större än " + number + ".");
            }

        }


        //==========start of int GetIntInput (string "question") method===================
        //simple method to ask for a int and making sure the input can be converted.
        static int GetIntInput(string question = "Vänligen ange ett positivt heltal: ")
        {
            Console.Write(question);
            string input = Console.ReadLine();
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
        //==========end of int GetIntInput (string "question") method===================
    }
}
