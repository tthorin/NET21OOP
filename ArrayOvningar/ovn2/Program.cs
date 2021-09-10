using System;
using System.Collections.Generic;

namespace ovn2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new();
            int[] siffror = new int[10];
            int sum = 0;

            for (int i = 0; i < siffror.Length; i++)
            {
                siffror[i] = random.Next(1, 51);
                sum += siffror[i];
                Console.WriteLine(siffror[i]);
            }

            int mean = sum / siffror.Length;
            Console.WriteLine("Summa: " + sum);
            Console.WriteLine("Medel: " +mean);

        }
    }
}
