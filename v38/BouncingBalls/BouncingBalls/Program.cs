namespace BouncingBalls
{
    using System;
    using System.Threading;

    class Program
    {
        static void Main(string[] args)
        {
            Ball ballOne = new Ball();
            Ball ballTwo = new Ball(1, -1, "*");
            Ball ballThree = new Ball(-1, 1, "#");
            ballOne.SetBallPosition(10, 10);
            ballTwo.SetBallPosition(20, 5);
            ballThree.SetBallPosition(60, 20);
            Console.CursorVisible = false;
            while (true)
            {
                ballOne.MoveIt();
                ballTwo.MoveIt();
                ballThree.MoveIt();
                Thread.Sleep(75);
            }
        }
    }
}
