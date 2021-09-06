using System;

namespace ovning4_foreach
{
    class Program
    {
        static void Main()
        {
            
            Console.Write("Skriv in ditt namn: ");
            string name = Console.ReadLine();

            foreach (char letter in name)
            {
                Console.WriteLine(letter);
            }
        }
    }
}
