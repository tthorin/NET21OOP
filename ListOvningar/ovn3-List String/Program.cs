namespace ovn3_List_String
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            List<string> names = new()
            {
                "Avar Kriss",
                "Depa Billaba",
                "Ezra Bridger",
                "Eno Cordova",
                "Cin Drallig",
                "Sifo-Dyas",
                "Kanan Jarrus",
                "Qui-Gon Jinn",
                "Cere Junda",
                "Obi-Wan Kenobi",
                "Cal Kestis",
                "Jocasta Nu",
                "Rey",
                "Mace Windu"
            };

            names.Sort();

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
