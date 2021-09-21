namespace BouncingBalls
{
    using System;
    using System.Threading;

    class Program
    {
        static void Main(string[] args)
        {
#pragma warning disable CA1416 // Validate platform compatibility
            Console.WindowHeight = Console.LargestWindowHeight;
            Console.WindowWidth = Console.LargestWindowWidth;
            //Console.WindowHeight = 60;
            //Console.WindowWidth = 250;
#pragma warning restore CA1416 // Validate platform compatibility

            Ball[] balls = new Ball[200];
            for (int ball = 0; ball < balls.Length; ball++)
            {
                balls[ball] = new Ball(true,1);
            }

            Console.CursorVisible = false;

            while (true)
            {   
                foreach (var ball in balls)
                {
                    ball.MoveIt();
                }
                Thread.Sleep(75);
            }
        }
    }
}
