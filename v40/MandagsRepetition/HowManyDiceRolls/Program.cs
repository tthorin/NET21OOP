namespace HowManyDiceRolls
{
    using System;

    class Program
    {
        static void Main()
        {
            // Alternativ (från Stackoverflow) https://stackoverflow.com/a/1785752
            // Random rand = new Random(Guid.NewGuid().GetHashCode());

            Random dice = new Random((int)DateTime.Now.Ticks);
            int result = 0;
            int counter = 0;

            while (result != 6)
            {
                counter++;
                result = dice.Next(1, 7); //måste alltid vara 1 mer än önskat så 7 om man vill ha max 6
                Console.WriteLine($"Tärning {counter}: {result}"); 
            }
        }
    }
}
