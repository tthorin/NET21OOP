using System;
using System.Threading;

namespace ovning2_DoWhile
{
    class Program
    {
        static void Main()
        {
            int ballXPos = 0;
            int row = 10;
            string input = "";
            
            Console.WriteLine("Ange ett tal mellan 1 och 80");
            input = Console.ReadLine();
            int.TryParse(input, out ballXPos);

            Console.CursorVisible = false;
            Console.Clear();

            do
            {
                
                Console.SetCursorPosition(ballXPos, row);
                Console.Write("O");

                Thread.Sleep(50);

                Console.SetCursorPosition(ballXPos, row);
                Console.Write(" ");
                ballXPos--;

            } while (ballXPos > 0);
        }
    }
}
