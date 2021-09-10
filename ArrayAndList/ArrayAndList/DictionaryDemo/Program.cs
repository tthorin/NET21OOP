namespace DictionaryDemo
{
    using System;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dict = new();
            dict.Add("Cat", "Katt");
            dict.Add("Dog", "Hund");
            dict.Add("Deer", "Rådjur");

            Console.WriteLine(dict["Dog"]);

            if (dict.ContainsKey("Deer"))
                Console.WriteLine(dict["Deer"]);
            else
                Console.WriteLine("Deer not found.");

            foreach (KeyValuePair<string,string> item in dict)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

            (int, string) tuple = new(1, "Hello");
            Console.WriteLine(tuple.Item1);
            Console.WriteLine(tuple.Item2);
        }
    }
}
