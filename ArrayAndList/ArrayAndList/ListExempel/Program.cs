using System;
using System.Collections.Generic;

namespace ListExempel
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> siffror = new()
            {
                10,
                9,
                24,
                56
            };
            siffror.Add(10);
            siffror.Add(22);
            siffror.Insert(1, 55);

            foreach (int siffra in siffror)
            {
                Console.WriteLine(siffra);
            }
        }
    }
}
