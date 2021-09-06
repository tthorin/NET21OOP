using System;

namespace while_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //int value = 0;

            //while (value<120)
            //{
            //    Console.SetCursorPosition(value, 10);
            //    Console.WriteLine("*");
            //    value++;
            //    System.Threading.Thread.Sleep(100);
            //}

            bool isValid = false;

            while (!isValid)
            {
                Console.WriteLine("Skriv lösenordet:");
                string input = Console.ReadLine();
                isValid = (input == "abc123");
            }
        }
    }
}
