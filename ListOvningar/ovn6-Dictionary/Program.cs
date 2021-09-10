namespace ovn6_Dictionary
{
    using System;
    using System.Collections.Generic;
    class Program
    {
        static void Main()
        {
            Dictionary<string, string> pladderBot = new();
            pladderBot.Add("hej", "Hejsan!");
            pladderBot.Add("hur mår du", "Bra, tack och du?");
            pladderBot.Add("bra", "Det gör mig glad.");
            pladderBot.Add("dåligt","Det gör mig ledsen.");
            pladderBot.Add("inte bra", "Attans!");
            pladderBot.Add("vad heter du", "PladderBot");
            pladderBot.Add("hej då","Hej då!");
            string input = "";

            do
            {
                Console.Write("Skriv något (PladderBot online): ");
                input = Console.ReadLine().ToLower();
                if (pladderBot.ContainsKey(input))
                {
                    Console.WriteLine(pladderBot[input]);
                }

            } while (input != "sluta" && input != "hej då");
        }
    }
}
