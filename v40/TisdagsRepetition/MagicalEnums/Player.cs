namespace MagicalEnums
{
    public class Player
    {
        public Race Race { get; set; }
        public Weapon Weapon { get; set; }
        public string Name { get; set; }
        public int Atk { get; set; }
        public int Hp { get; set; }
        public int Mp { get; set; }
        public int Def { get; set; }
        public int Luck { get; set; }

        public override string ToString()
        {
            return $"Namn: {Name}|Ras: {Race}|Vapen: {Weapon}|Attack: {Atk}|Försvar: {Def}|Tur: {Luck}|Hälsa: {Hp}|Magipoäng: {Mp}";
        }

    }
}
