using System;
using System.Collections.Generic;

namespace ArrayOvningar
{
    class Program
    {
        static void Main()
        {
            Console.Write("Vad heter du? ");
            string input = Console.ReadLine().Trim();
            Console.WriteLine("Första och sista bokstaven: " + input[0] + input[input.Length-1]);

        }
    }
}
