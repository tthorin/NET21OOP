using System;
using System.Collections.Generic;

namespace foreachDemo
{
    class Program
    {
        static void Main()
        {
            List<string> name = new()
            {
                "Batman",
                "Robin",
                "Catwoman"
            };
            //string name = "Thomas";
            foreach (string letter in name)
            {
                Console.WriteLine(letter);
            }
        }
    }
}
