namespace BouncingBalls
{
    using System;
    internal class Ball
    {
        int X = 0;
        int Y = 0;
        int PlusX = 1;
        int PlusY = 1;
        string BallShape = "O";

        public Ball(int plusX, int plusY, string ballShape)
        {
            PlusX = plusX;
            PlusY = plusY;
            BallShape = ballShape;
        }
        public Ball()
        {
            PlusX = 1;
            PlusY = 1;
        }
        public Ball(string ballShape)
        {
            PlusX = 1;
            PlusY = 1;
            BallShape = ballShape;
        }

        private void CheckBoundaries()
        {
            if (X <= 1 || X >= Console.WindowWidth -1)
            {
                PlusX = -PlusX;
            }
            if (Y <= 1 || Y >= Console.WindowHeight - 1)
            {
                PlusY = -PlusY;
            }
        }
        public void MoveIt()
        {
            CheckBoundaries();
            Console.SetCursorPosition(X, Y);
            Console.Write(" ");
            X += PlusX;
            Y += PlusY;
            Console.SetCursorPosition(X, Y);
            Console.Write(BallShape);
        }
        public void SetBallPosition(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}