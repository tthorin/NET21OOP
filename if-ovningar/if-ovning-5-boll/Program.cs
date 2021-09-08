﻿using System;

namespace if_ovning_5_boll
{
    class Program
    {
        static void Main()
        {
            int verticalPosition = 1;
            int horizontalPosition = 1;
            int verticalSpeed = 1;
            int horizontalSpeed = 1;

            int minHorizontal = 2;
            int maxHorizontal = 112;
            int minVertical = 2;
            int maxVertical = 25;

            Console.CursorVisible = false;
            Random rng = new Random();

            //for (int i = 0; i < 25; i++)
            //{
            //    if (i > 20)
            //        Console.BackgroundColor = ConsoleColor.Green;
            //    else
            //        Console.BackgroundColor = ConsoleColor.Blue;
            //    for (int j = 0; j < 120; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //}

            while (true)
            {
                //Console.Clear();
                if (horizontalPosition > maxHorizontal)
                {
                    horizontalSpeed = -1;
                }
                else if (horizontalPosition < minHorizontal)
                {
                    horizontalSpeed = 1;
                }

                if (verticalPosition > maxVertical)
                {
                    verticalSpeed = -5;
                }
                else if (verticalPosition < minVertical)
                {
                    verticalSpeed = 1;
                }
                if (verticalPosition > 2 && verticalSpeed == 1)
                {
                    verticalSpeed = 5;
                    if (horizontalSpeed > 0)
                        horizontalSpeed = 1;
                    else
                        horizontalSpeed = -1;
                }
                if (verticalPosition < maxVertical / 2 && verticalSpeed == -5)
                {
                    verticalSpeed = -3;
                   
                }

                if (verticalPosition < maxVertical / 4 && verticalSpeed == -3)
                {
                    verticalSpeed = -1;
                    if (horizontalSpeed > 0)
                        horizontalSpeed = 2;
                    else
                        horizontalSpeed = -2;
                }

                verticalPosition += verticalSpeed;
                horizontalPosition += horizontalSpeed;

                

                //slumpvis färg lösning från https://stackoverflow.com/questions/17456788/how-to-randomly-pick-one-of-known-console-colors-for-text
                Console.ForegroundColor = (ConsoleColor)rng.Next(1, 16);

                //Console.SetCursorPosition(horizontalPosition, verticalPosition);
                //Console.Write("☺");


                //rabbit vMax=25 hMax = 112
                if (horizontalSpeed > 0)
                {
                    Console.SetCursorPosition(horizontalPosition, verticalPosition);
                    Console.Write(" (\\ /)");
                    Console.SetCursorPosition(horizontalPosition, verticalPosition + 1);
                    Console.Write(" ( ..)");
                    Console.SetCursorPosition(horizontalPosition, verticalPosition + 2);
                    Console.Write("c(\")(\")");
                }
                else
                {
                    Console.SetCursorPosition(horizontalPosition, verticalPosition);
                    Console.Write(" (\\ /)");
                    Console.SetCursorPosition(horizontalPosition, verticalPosition + 1);
                    Console.Write(" (.. )");
                    Console.SetCursorPosition(horizontalPosition, verticalPosition + 2);
                    Console.Write("(\")(\")?");
                }

                //cat vMax = 25 hMax = 90
                //Console.SetCursorPosition(horizontalPosition, verticalPosition);
                //Console.Write("Zzzzz  |\\      _,,,--,,_     ");
                //Console.SetCursorPosition(horizontalPosition, verticalPosition+1);
                //Console.Write("       /,`.-'`'   ._  \\-;;,_ ");
                //Console.SetCursorPosition(horizontalPosition, verticalPosition + 2);
                //Console.Write("      |,4-  ) )_   .;.(  `'-'");
                //Console.SetCursorPosition(horizontalPosition, verticalPosition + 3);
                //Console.Write("     '---''(_/._)-'(_\\_)     ");

                System.Threading.Thread.Sleep(60);

                Console.SetCursorPosition(horizontalPosition, verticalPosition);
                Console.Write("      ");
                Console.SetCursorPosition(horizontalPosition, verticalPosition + 1);
                Console.Write("      ");
                Console.SetCursorPosition(horizontalPosition, verticalPosition + 2);
                Console.Write("       ");



            }
        }
    }
}
