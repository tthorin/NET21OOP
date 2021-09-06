using System;

namespace do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "abc123";
            string input = "";

            do
            {
                Console.WriteLine("Ange lösen:");
                input = Console.ReadLine();

            } while (input != password);
        }
    }
}
