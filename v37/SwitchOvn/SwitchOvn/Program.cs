
namespace SwitchOvn
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ange ett tal: ");
            _ = int.TryParse(Console.ReadLine(), out int number);

            switch (number)
            {
                case 11: Console.WriteLine("Talet är 11"); break;
                case 22: Console.WriteLine("Talet är 22"); break;
                case 33:  Console.WriteLine("Talet är 33");  break;
                case 44:   Console.WriteLine("Talet är 44");  break;
                case < 1: Console.WriteLine("Talet är för litet");  break;
                case < 10:  Console.WriteLine("Talet är under 10");  break;
                case < 20: Console.WriteLine("Talet är under 20"); break;
                case < 30:  Console.WriteLine("Talet är under 30"); break;
                case < 40:Console.WriteLine("Talet är under 10"); break;
                case > 50:   Console.WriteLine("Alldeles för högt tal!"); break;
                default: break;
            }
        }
    }
}
