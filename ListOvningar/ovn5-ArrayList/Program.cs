namespace ovn5_ArrayList
{
    using System;
    using System.Collections;

    class Program
    {
        static void Main()
        {
            Random rng = new();
            ArrayList myList = new ArrayList()
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

            for (int i = 0; i < 10; i++)
            {
                myList.Add(rng.Next(1, 101));
            }

            foreach (object item in myList)
            {
                if (item is int)
                    Console.WriteLine("int: "+ item + " * 2 = " +(int)item * 2);
                else
                    Console.WriteLine("Not int: "+item);
            }

        }
    }
}
