namespace BabyShark
{
    using System;

    class Program
    {
        static void Main()
        {
            for (int i = 0; i < 15; i++)
            {
                if (i % 5 == 0)
                {
                    Console.Write("Baby Shark "); // ♩ ♪ ♫
                }
                else if (i == 4 || i == 9|| i ==14)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.Write("Do ");
                }
            }
            Console.ReadKey();
        }
    }
}
