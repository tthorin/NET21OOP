using System;

namespace if_satser
{
    class Program
    {
        static void Main()
        {
            int value = 0;
            Console.Write("Skriv ett nummer: ");
            string strInput = Console.ReadLine();

            bool doesWork = int.TryParse(strInput, out value);

            Console.WriteLine("Du angav: " + value);
        }
    }
}
