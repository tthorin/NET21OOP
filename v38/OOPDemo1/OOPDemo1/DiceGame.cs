namespace OOPDemo1
{
    using System;
    internal class DiceGame
    {
        private int max;
        private int value;
        public int Value { get => value; }
        public DiceGame(int max)
        {
            max = max;
        }
        public DiceGame()
        {
            max = 6;
        }
        public int RollDice()
        {
            Random rng = new();
            this.value = rng.Next(1, max + 1);
            return Value;
        }
    }
}