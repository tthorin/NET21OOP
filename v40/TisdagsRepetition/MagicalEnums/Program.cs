namespace MagicalEnums
{
    using System;
    class Program
    {
        static void Main()
        {
            Game rpg = new();
            rpg.GenerateRandomPlayer();
            rpg.ShowPlayer();
            Console.ReadKey();
        }
    }
}
