namespace Medel
{
    using System;


    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new();
            
            int[] numbers = new int[5];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rng.Next(1, 101);
            }

            Console.Write(Medelvärde(numbers));

        }

        static public double Medelvärde(int[] allaTal)
        {
            int summa  =  0;
            foreach (var item in allaTal)
            {
                summa   +=   item;
            }
            double medel = (double)summa / allaTal.Length;
            return medel;
           
        }

    }
}
