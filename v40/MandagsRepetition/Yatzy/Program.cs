namespace Yatzy
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    class Die
    {
        public int Value { get; private set; } = 0;
        static Random rnd = new Random();
        

        public Die() => RollDie();

        public int RollDie()
        {
            Value = rnd.Next(1, 7);
            return Value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }

    }
    /*
     *  • Dices = En array eller lista av tärningarnas värden
        • Chance = Summan av alla tärningar
        • TwoOAK= Two Of Same Kind, 0 eller värdet som är dubbel
        • ThreeOAK = Three Of Same Kind = 0 eller värdet som är triss
        • FourOAK = Four Of Same Kind = 0 eller värdet som är fyrtal
        • Yatzy = Gemensamma värdet som alla tärningar har
        • Klassen ska ha en metod som ska heta RollTheDices() där den ska kasta alla fem tärningar.
    */
    class Dice
    {
        public Die[] dice = new Die[5];//<=======
        public int[] diceResult = new int[5];
        public Dictionary<int, int> result = new Dictionary<int, int>(); 

        public Dice()
        {
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = new Die();
            }
        }

        public int Chance
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < dice.Length; i++)
                {
                    sum += dice[i].Value;
                }
                return sum;
            }
            private set
            {

            }
        }
        public int TwoOAK { get; set;  }

        private void SetResult()
        {
            NumberOfSameDice = 0;
            TwoOAK = 0;
            foreach (var kvp in result)
            {
                if (kvp.Value > NumberOfSameDice)
                {
                    NumberOfSameDice = kvp.Value;
                    TwoOAK = kvp.Key;
                }
            }
        }

        public int NumberOfSameDice { get; set; }

        public void RollTheDice()
        {
            Array.Clear(diceResult, 0, diceResult.Length);
            for (int i = 0; i < dice.Length; i++)
            {
                diceResult[i] = dice[i].RollDie(); 
            }
            CheckSame();
        }

        public void CheckSame()
        {
            result.Clear();

            var groups = dice.GroupBy(x => x.Value);

            foreach(var group in groups)
            {
                result.Add(group.Key, group.Count());
            }
            SetResult();

        }
        // Kolla https://stackoverflow.com/a/27233955


    }
    class Program
    {
        static void Main(string[] args)
        {
            Dice yatzy = new();
            yatzy.RollTheDice();

            for(int i=0; i<yatzy.dice.Length; i++)
            {
                Console.WriteLine($"Tärning #{i+1}: " + yatzy.dice[i].Value);
            }

            foreach  (var r in yatzy.result)
            {
                Console.WriteLine(r.Value.ToString() + " st " + r.Key.ToString() + ":or");
            }

            Console.WriteLine($"Du fick {yatzy.NumberOfSameDice} st. {yatzy.TwoOAK}:or");

            Console.ReadLine();
        }
    }
}
