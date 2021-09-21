namespace BouncingBalls
{
    using System;
    using System.Collections.Generic;
    internal class Ball
    {
        private double x;
        private double y;
        double PlusX = 1;
        double PlusY = 1;
        string BallShape = "O";
        int trail = 1;
        int maxSpeed = 3;
        static int maxX = Console.WindowWidth-1;
        static int maxY = Console.WindowHeight-1;
        Queue<int> xMemory = new();
        Queue<int> yMemory = new();

        public double X
        {
            get => x;
            set
            {
                if (value > maxX-BallShape.Length) x = maxX - BallShape.Length;
                else if (value < 0) x = 0;
                else x = value;
            }
        }
        public double Y
        {
            get => y; 
            set
            {
                if (value > maxY) y = maxY;
                else if (value < 0) y = 0;
                else y = value;
            }
        }

        public Ball(bool randomSetup=true, int trail = 3)
        {   
            if (randomSetup) RandomBallSetup();
            this.trail = trail;
        }
        public Ball(double x = 1, double y = 1, double plusX = 0.75, double plusY = 2, int trail = 1)
        {
            this.X = x;
            this.Y = y;
            this.PlusX = plusX;
            this.PlusY = plusY;
            this.trail = trail;
        }

        public void MoveIt()
        {
            CheckScreenSize();
            CheckBoundaries();
            DeleteOldBall();
            X += PlusX; //update pos
            Y += PlusY;
            Console.SetCursorPosition((int)X, (int)Y);//move cursor to new pos
            Console.Write(BallShape);//print ball
            xMemory.Enqueue((int)X); //save pos
            yMemory.Enqueue((int)Y);
        }
        private void CheckBoundaries()
        {
            //if the balls current pos + speed would make it go out of bounds left or right
            if (X + PlusX < 0 || X + PlusX > (maxX - BallShape.Length))
            {
                if (X + PlusX > (maxX - BallShape.Length)) X = maxX - BallShape.Length;
                //it the ball is going almost straight left or right
                //make it exit screen and reappear at opposite side
                if (Math.Abs(PlusY) < 0.5)
                {
                    if (PlusX > 0) X = 1;
                    else X = maxX - BallShape.Length;
                }
                else PlusX = -PlusX; //reverse direction
            }
            //if the balls current pos + speed would make it go out of bounds up or down
            if (Y + PlusY < 0 || Y + PlusY > maxY)
            {
                if (Y + PlusY > maxY) Y = maxY;
                //it the ball is going almost straight up or down
                //make it exit screen and reappear at opposite side
                if (Math.Abs(PlusX) < 0.5)
                {
                    if (PlusY > 0) Y = 1;
                    else Y = maxY;
                }
                else PlusY = -PlusY; //reverse
            }
        }

        private void CheckScreenSize()
        {
            if (Console.WindowHeight != maxY+1 || Console.WindowWidth != maxX+1)
            {
                Console.Clear();
                xMemory.Clear();
                yMemory.Clear();
                maxY = Console.WindowHeight-1;
                maxX = Console.WindowWidth-1;
                Console.CursorVisible = false;
            }
            return;
        }
        private void DeleteOldBall()
        {
            if (xMemory.Count == trail)
            {
                int xToDelete = xMemory.Dequeue();
                if (xToDelete > maxX) xToDelete = maxX - BallShape.Length;
                int yToDelete = yMemory.Dequeue();
                if (yToDelete > maxY) yToDelete = maxY;
                Console.SetCursorPosition(xToDelete, yToDelete); //get position of previously printed ball
                Console.Write(new string(' ', BallShape.Length));//overwrite it 
            }
        }


        public void SetBallPosition(double x, double y)
        {
            if (x < 0 || x > (Console.WindowWidth - BallShape.Length))
            {
                if (x < 0) this.X = 0;
                else this.X = Console.WindowWidth - BallShape.Length;
            }
            else this.X = x;
            if (y < 0 || y > Console.WindowHeight)
            {
                if (y < 0) this.Y = 0;
                else this.Y = Console.WindowHeight;
            }
            else this.Y = y;
        }
        public void RandomBallSetup()
        {
            Random rng = new();
            do
            {
                PlusX = rng.NextDouble() * maxSpeed;
                PlusY = rng.NextDouble() * maxSpeed;
            } while (PlusX < 0.3d && PlusY < 0.3d); //discard balls that would move too slow
            X = rng.NextDouble() * Console.WindowWidth;
            Y = rng.NextDouble() * Console.WindowHeight;
            string[] ballShapes = new string[] { "*", "O", "0", "@", "#", ".", "X", "(-O-)", "o" };
            BallShape = ballShapes[rng.Next(0, ballShapes.Length)];
        }

    }
}