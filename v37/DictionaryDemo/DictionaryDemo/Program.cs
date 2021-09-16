

namespace DictionaryDemo
{
    using System;
    using System.Collections.Generic;
    class Program
    {
        static void Main()
        {
            SortedDictionary<string, string> names = new();
            names.Add("Batman", "Bruce Wayne");
            names.Add("Superman", "Clark Kent");
            names.Add("Catwoman", "Celina Kyle");
            names.Add("Equalizer", "Denzel Washington");

            foreach (KeyValuePair<string,string> kvp in names)
            {
                Console.WriteLine(kvp.Value + " is " + kvp.Key);
            }
        }
    }
}
