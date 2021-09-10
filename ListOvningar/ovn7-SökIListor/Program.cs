namespace ovn7_SökIListor
{
    using System;
    using System.Collections.Generic;
    class Program
    {
        static void Main()
        {
            List<string> names = new()
            {
                "Harry",
                "Dumbeldore",
                "Ron",
                "Voldemort",
                "Hermione",
                "Hagrid",
                "George",
                "Fred",
                "Severus",
                "Hedwig"
            };

            Console.Write("Vilket namn vill du söka efter? ");
            string input = Console.ReadLine();

            //enkla lösningen:
            int indexOfnameWeWant = names.IndexOf(input);
            if (indexOfnameWeWant > -1)
                Console.WriteLine("Namnet fanns på index: "+indexOfnameWeWant+" ("+ names[indexOfnameWeWant]+")");
            else
                Console.WriteLine("Namnet fanns inte i listan");

            
            for (int i = 0; i < names.Count; i++)
            {
                bool found = false;
                if (names[i].ToLower() == input.ToLower())
                {
                    Console.WriteLine($"Index [{i}]: {names[i]}");
                    if (!found)
                        found = true;
                }
                if (i == names.Count-1 && !found)
                    Console.WriteLine("Kunde inte hitta det namnet.");
            }
        }
    }
}
