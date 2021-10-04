namespace MandagsRepetition
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            double distance = 344.24d;
            double fuelConsumption = 6.7 / 100;
            double fuelPrice = 17.24;
            double price = distance * fuelConsumption * fuelPrice;

            Console.WriteLine("Resan kostar: "+ Math.Round(price,2)+ " kr.");
        }
    }
}
