namespace BouncingBalls
{
    using System;
    using System.Threading;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowHeight = 84;
            Console.WindowWidth = 317;
            Ball[] balls = new Ball[50];
            for (int ball = 0; ball < balls.Length; ball++)
            {
                balls[ball] = new Ball();
                balls[ball].RandomBallSetup();
            }
            Console.CursorVisible = false;
            while (true)
            {
                Console.CursorVisible = false;
                foreach (var ball in balls)
                {
                    ball.MoveIt();
                }
                Thread.Sleep(75);
            }
        }
    }
}
