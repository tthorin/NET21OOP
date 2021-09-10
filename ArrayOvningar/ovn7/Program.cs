using System;

namespace ovn7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] gameMap = new int[90,10];
            int posX = 0;
            int posY = 0;
            while (true)
            {
                Console.Write("Ange X koordinat (mellan 0 och 89): ");
                string stringX = Console.ReadLine();
                _=int.TryParse(stringX, out posX);
                
                Console.Write("Ange Y koordinat (mellan 0 och 9): ");
                string stringY = Console.ReadLine();
                _=int.TryParse(stringY, out posY);
                gameMap[posX, posY] = 1;

                Console.Clear();
                for (int i = 0; i < gameMap.GetUpperBound(1)+1; i++)
                {
                    for (int j = 0; j < gameMap.GetUpperBound(0)+1; j++)
                    {
                        if (gameMap[j,i] == 1)
                        {
                            Console.SetCursorPosition(j,i);
                            Console.Write("X");
                        }
                    }

                }
                Console.SetCursorPosition(0, gameMap.GetUpperBound(1)+1);
            }
        }
    }
}
