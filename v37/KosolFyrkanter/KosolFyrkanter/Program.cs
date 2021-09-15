using System;

namespace KonsolFyrkanter
{
    class Program
    {
        static void Main(string[] args)
        {
            int heigth = AskForNumber("Ange höjden (max 20): ");
            int width = AskForNumber("Ange bredden (max 110): ");

            for (int i = 0; i < heigth; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (i == 0 || i == heigth - 1) Console.Write("*");
                    else if (j == 0 || j == width - 1) Console.Write("*");
                    else
                    {
                        if (i % 2 == 0)
                        {
                            if (j % 2 == 0) Console.Write("*");
                            else Console.Write(" ");
                        }
                        else
                        {
                            if (j % 2 == 1) Console.Write("*");
                            else Console.Write(" ");
                        }
                    }
                }
                Console.WriteLine("");
            }
        }

        static int AskForNumber(string question = "Ange ett tal: ")
        {
            Console.Write(question);
            string input = Console.ReadLine();
            _ = int.TryParse(input, out int number);
            return number;
        }

    }
}
