namespace TryCatch2
{
    using System;
    using System.Threading;

    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(100, 24);
            Console.SetBufferSize(100, 24);
            int x = Console.WindowWidth/2;
            int y = Console.WindowHeight/2;
            int plusX = 1;
            int plusY = 1;

            while (true)
            {
                x += plusX;
                y += plusY;
                if (x > 98 || x < 1) plusX = -plusX;
                if (y > 22 || y < 1) plusY = -plusY;
                Console.SetCursorPosition(x, y);
                Console.Write("O");
                Thread.Sleep(100);
            }

            
            while (true)
            {
                x += plusX;
                y += plusY;
                try
                {
                    Console.CursorLeft = x;

                }
                catch (Exception ex)
                {
                    plusX = -plusX;
                }
                try
                {
                    Console.CursorTop = y;

                }
                catch (Exception ex)
                {
                    plusY = -plusY;
                }
                Console.Write("O");
                Thread.Sleep(100);
            }

        }
    }
}
