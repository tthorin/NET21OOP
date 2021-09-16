

namespace DictionaryDemo
{
    using System;
    using System.Collections.Generic;
    class Program
    {
        static void Main()
        {
            SortedDictionary<string, string> heroes = new();
            AddToDicationary(heroes,"Batman", "Bruce Wayne");
            AddToDicationary(heroes, "Superman", "Clark Kent");
            AddToDicationary(heroes, "Catwoman", "Celina Kyle");
            AddToDicationary(heroes, "Equalizer", "Denzel Washington");
            AddToDicationary(heroes, "Equalizer", "Robert McCall");
            AddToDicationary(heroes, "Spiderman", "Peter Parker");
            
            
            foreach (KeyValuePair<string,string> kvp in heroes)
            {
                Console.WriteLine(kvp.Key + " is " + kvp.Value);
            }

            var find = heroes.Keys;
            Console.WriteLine(find);
        }

        static void AddToDicationary(SortedDictionary<string, string> heroes, string key, string value)
        {
            if (heroes.TryAdd(key,value))
            {
                Console.WriteLine(key + " is ok.");
            }
            else
            {
                if (heroes.ContainsKey(key))
                {
                    Console.WriteLine(key + " updated.");
                }
                heroes[key] = value;
            }
            return;
        }
    }
}
