namespace SwitchDemo
{
    using System;
    enum Dagar
    {
        Måndag=1, Tisdag, Onsdag, Torsdag, Fredag, Lördag, Söndag
    }
    enum Directions
    {
        North,East,South,West
    }
    class Program
    {
        static void Main()
        {

            Console.Write("Skriv ett tal: ");
            _ = int.TryParse(Console.ReadLine(), out int number);

            Dagar day = Dagar.Måndag;
            Directions dir = Directions.North;

            GoDirection(dir);

            switch (day)
            {
                case Dagar.Måndag:
                    break;
                case Dagar.Tisdag:
                    break;
                case Dagar.Onsdag:
                    break;
                case Dagar.Torsdag:
                    break;
                case Dagar.Fredag:
                    break;
                case Dagar.Lördag:
                    break;
                case Dagar.Söndag:
                    break;
                default:
                    break;
            }

            string resultat = string.Empty;

            switch (number)
            {
                case 1337: resultat = "Leet"; break;
                case < 100: resultat = "Mindre än hundra"; break;
                case > 100: resultat = "Mer än hundra"; break;
                default: resultat = "Skumt"; break;
            }
            Console.WriteLine(resultat);


        }

        private static void GoDirection(Directions dir)
        {
            switch (dir)
            {
                case Directions.North:
                    break;
                case Directions.East:
                    break;
                case Directions.South:
                    break;
                case Directions.West:
                    break;
                default:
                    break;
            }
        }
    }
}
