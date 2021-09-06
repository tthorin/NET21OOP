using System;

namespace ovning3_for
{
    class Program
    {
        static void Main()
        {
            int sum = 0;
            int value = 0;
            string input = "";


            Console.Write("Ange ett värde till for loopen: ");
            input = Console.ReadLine();
            int.TryParse(input, out value);

            for (int i = 0; i < value; i++)
            {
                sum += value;
            }

            Console.WriteLine($"summan blev: {sum}");
        }
    }
}
