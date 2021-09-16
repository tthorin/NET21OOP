

namespace EnumOvn
{
    using EnumOvn.Enums;
    using System;

    
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            while (number < 1 || number > 7)
            {
                Console.Write("Ange ett nummer mellan 1 och 7: ");
                _ = int.TryParse(Console.ReadLine(), out number);
            }
            Console.WriteLine("Du valde "+(Veckodagar)number);
        }
    }
}
