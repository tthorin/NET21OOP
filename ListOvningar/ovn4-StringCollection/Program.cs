namespace ovn4_StringCollection
{ 
    using System;
    using System.Collections.Specialized;

    class Program
    {
        static void Main(string[] args)
        {
            StringCollection names = new()
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

            //StringCollection inhåller inte sort =(
            string[] namesArray = new string[names.Count];
            names.CopyTo(namesArray, 0);
            Array.Sort(namesArray);
            names.Clear();
            names.AddRange(namesArray);

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
