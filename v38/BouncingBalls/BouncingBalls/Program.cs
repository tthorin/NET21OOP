namespace BouncingBalls
{
    using System;
    using System.Threading;

    class Program
    {
        static void Main(string[] args)
        {
            //Console.WindowHeight = Console.LargestWindowHeight;
            //Console.WindowWidth = Console.LargestWindowWidth;
            Console.WindowHeight = 60;
            Console.WindowWidth = 250;

            Ball[] balls = new Ball[50];
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
