namespace ListOvningar
{
    using System;
    using System.Collections.Generic;
    class Program
    {
        static void Main()
        {
            List<int> numbers = new();
            Random rng = new();

            for (int i = 0; i < 10; i++)
            {
                numbers.Add(rng.Next(100));
            }

            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            int mean = sum / numbers.Count;

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("Summan är: " + sum);
            Console.WriteLine("Medelvärder är: " + mean);
        }
    }
}
