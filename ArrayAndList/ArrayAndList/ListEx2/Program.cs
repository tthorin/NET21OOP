using System;
using System.Collections.Generic;

namespace ListEx2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new()
            {
                "Harley Quinn",
                "Poison Ivy",
                "Catwoman",
                "Penguin",
                "Penguin",
                "Fish"
            };
            int x = names.GetUpperBound();

            if (names.Contains("Penguin"))
            {
                int idx = names.IndexOf("Penguin");
                //names.Remove("Penguin");
                names.RemoveAt(idx);
            }

            names.Remove("Penguin");
            names.Sort();

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
