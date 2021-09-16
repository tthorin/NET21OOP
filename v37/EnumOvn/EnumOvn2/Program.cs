

namespace EnumOvn2
{
    using System;
    enum Veckodagar
    {
        Måndag = 1,
        Tisdag,
        Onsdag,
        Torsdag,
        Fredag,
        Lördag,
        Söndag
    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ange en veckodag: ");
            string input = Console.ReadLine();

            input = input.ToLower();
            string dayName = input.Substring(0, 1).ToUpper();
            dayName += input.Substring(1);

            object? objThing = null;
            Enum.TryParse(typeof(Veckodagar), dayName, out objThing);
            Veckodagar day = (Veckodagar)objThing;

            Console.WriteLine((int)day);            
        }
    }
}
