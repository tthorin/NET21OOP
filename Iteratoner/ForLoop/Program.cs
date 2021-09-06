using System;

namespace ForLoop
{
    class Program
    {
        static void Main()
        {
            for (int counter = 1; counter < 11; counter++)
            {
                if (counter == 4) continue;
                Console.WriteLine(counter);

            }
        }
    }
}
