using System;

namespace ovning1_While
{
    class Program
    {
        static void Main()
        {
            int memory = 0;
            int value = 0;
            string input = "";

            while (value >= 0)
            {
                Console.Write("Ange ett värde (negativt värde för att avsluta): ");
                input = Console.ReadLine();
                int.TryParse(input, out value);
                if (value > 0)
                {
                    memory += value;
                }
            }
            Console.WriteLine($"Summan av alla inmatade tal blev: {memory}");
        }
    }
}
