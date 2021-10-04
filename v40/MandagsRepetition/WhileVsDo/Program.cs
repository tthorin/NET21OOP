namespace WhileVsDo
{
    using System;

    class Program
    {
        static void Main()
        {
            int counter = 0;

            while (counter > 5 && counter < 10)
            {
                counter++;
            }
            Console.WriteLine("After while:" + counter);

            do
            {
                counter++;
            }
            while (counter > 5 && counter < 10);
            Console.WriteLine("After do: " + counter);
        }
    }
}
