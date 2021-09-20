namespace BouncingBalls
{
    using System;
    using System.Threading;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowHeight = Console.LargestWindowHeight;
            Console.WindowWidth = Console.LargestWindowWidth;
            
            Ball[] balls = new Ball[100];
            for (int ball = 0; ball < balls.Length; ball++)
            {
                balls[ball] = new Ball();
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
