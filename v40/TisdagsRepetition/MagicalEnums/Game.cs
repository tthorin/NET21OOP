namespace MagicalEnums
{
    using System;

    public class Game
    {
        public Player Pc { get; set; } = new();
        public void GenerateRandomPlayer()
        {
            Random rng = new();
            string[] namesToPickFrom = new string[] { "Merlin", "Legolas", "Knyttet", "Dracula", "Lilla My", "Tjatte", "Ronja", "Nikita" };
            Pc.Name = namesToPickFrom[rng.Next(0, namesToPickFrom.Length)];
            Pc.Race = (Race)rng.Next(0, Enum.GetNames(typeof(Race)).Length);
            Pc.Weapon = (Weapon)rng.Next(0, Enum.GetNames(typeof(Weapon)).Length);
            Pc.Atk = rng.Next(50, 101);
            Pc.Hp = rng.Next(50, 101);
            Pc.Mp = rng.Next(50, 101);
            Pc.Def = rng.Next(50, 101);
            Pc.Luck = rng.Next(50, 101);
        }
        public void ShowPlayer()
        {   
            Console.WriteLine(Pc.ToString().Replace("|","\n"));
        }
    }
}
