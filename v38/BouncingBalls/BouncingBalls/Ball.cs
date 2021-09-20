namespace BouncingBalls
{
    using System;
    using System.Collections.Generic;
    internal class Ball
    {
        double X = 0;
        double Y = 0;
        double PlusX = 1;
        double PlusY = 1;
        string BallShape = "O";
        int Trail = 5;
        int MaxSpeed = 3;
        Queue<int> XMemory = new();
        Queue<int> YMemory = new();

        public Ball()
        {
            for (int i = 0; i < Trail; i++)
            {
                XMemory.Enqueue(0);
                YMemory.Enqueue(0);
            }
        }

        private void CheckBoundaries()
        {
            if (X + PlusX < 0 || X + PlusX > (Console.WindowWidth-BallShape.Length))
            {
                if (Math.Abs(PlusY)<0.3)
                {
                    if (PlusX > 0) X = 1;
                    else X = Console.WindowWidth - BallShape.Length;
                }
                else PlusX = -PlusX;
            }
            if (Y + PlusY < 0 || Y + PlusY > Console.WindowHeight)
            {
                if (Math.Abs(PlusX) < 0.3)
                {
                    if (PlusY > 0) Y = 1;
                    else Y = Console.WindowHeight;
                }
                else PlusY = -PlusY;
            }
        }
        public void MoveIt()
        {
            CheckBoundaries();
            Console.SetCursorPosition(XMemory.Dequeue(), YMemory.Dequeue());
            Console.Write(new string(' ',BallShape.Length));
            X += PlusX;
            Y += PlusY;
            Console.SetCursorPosition((int)X, (int)Y);
            Console.Write(BallShape);
            XMemory.Enqueue((int)X);
            YMemory.Enqueue((int)Y);
        }
        public void SetBallPosition(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public void RandomBallSetup()
        {
            Random rng = new();
            do
            {
                PlusX = rng.NextDouble() * MaxSpeed;
                PlusY = rng.NextDouble() * MaxSpeed;
            } while (PlusX < 0.3d && PlusY < 0.3d);
            X = rng.NextDouble() * Console.WindowWidth;
            Y = rng.NextDouble() * Console.WindowHeight;
            string[] ballShapes = new string[] { "*", "O", "0", "@", "#", ".","X","(-O-)" };
            BallShape = ballShapes[rng.Next(0, ballShapes.Length)];
        }

    }
}