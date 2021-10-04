namespace MatteTabell
{
    using System;

    class Program
    {
        static void Main()
        {
            for (int tal = 1; tal < 11; tal++)
            {
                for (int multiplikator = 1; multiplikator < 11; multiplikator++)
                {
                    Console.Write(tal * multiplikator+"\t");
                }
                Console.WriteLine();
            }
            Console.Write("Vilken tabell vill du se? ");
            int.TryParse(Console.ReadLine(), out int siffra); 
            for (int i = 1; i < 11; i++)
            {
                Console.Write(i*siffra+"\t");
            }
        }
    }
}
