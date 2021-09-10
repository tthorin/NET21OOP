using System;
using System.Collections.Generic;

namespace ovn5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nameList = new string[]
            {
                "Nisse",
                "Pelle",
                "Gustav",
                "Karin",
                "Laban",
                "Holger",
                "Bertil",
                "Ceasar",
                "David",
                "Erik"
            };
            Console.WriteLine("Före sort:");
            foreach (string name in nameList)
            {
                Console.WriteLine(name);
            }
            Array.Sort(nameList);
            Console.WriteLine("\nEfter sort:");
            foreach (string name in nameList)
            {
                Console.WriteLine(name);
            }
        }
    }
}
