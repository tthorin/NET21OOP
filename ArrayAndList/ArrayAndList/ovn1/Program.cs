using System;

namespace ovn1
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            string[] food = new string[]
            {
                "Mjölk",
                "3 Mjau - Noga Utvalt Kyckling i Sås",
                "Bananer"
            };
            double[] pris = new double[] { 17.30d, 20d, 26.95d };

            for (int i = 0; i < food.Length; i++)
            {
                Console.WriteLine($"{food[i]} {pris[i]}");
                total += pris[i];
            }

            Console.WriteLine("Summa: " + total);
        }
    }
}
