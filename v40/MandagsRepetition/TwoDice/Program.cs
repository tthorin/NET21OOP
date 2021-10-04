using TwoDice;

namespace TwoDice
{
    using System;



    class Dice
    {
        public int Value { get; private set; } = 0;
        static Random rnd = new Random();

        public Dice() => RollDice();

        public int RollDice()
        {
            Value = rnd.Next(1, 7);
            return Value;
        }

    }

    class Program
    {
        static void Main()
        {
            int counter = 0;
            Dice dice1 = new();
            Dice dice2 = new();

            do
            {
                counter++;
                dice1.RollDice();
                dice2.RollDice();
                Console.WriteLine($"{counter}: Tärning 1: {dice1.Value} Tärning 2: {dice2.Value}");
                
            } while (dice1.Value != dice2.Value);

            Console.ReadLine();
        }
    }
}
