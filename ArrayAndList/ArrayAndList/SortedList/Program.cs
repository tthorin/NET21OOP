using System;
using System.Collections.Generic;

namespace SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, string> sort = new();
            sort.Add("Cat", "Katt");
            sort.Add("Dog", "Hund");
            sort.Add("Deer", "Rådjur");
            sort.Add("Amphibian", "Amfibie");

            foreach (KeyValuePair<string, string> item in sort)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
        }
    }
}
