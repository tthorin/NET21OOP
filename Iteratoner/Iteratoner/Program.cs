using System;

namespace Iteratoner
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            while (counter < 10)
            {
                counter++;
                //if (counter > 10)
                //{
                //    break;
                //}
                if (counter == 4)
                {
                    continue;
                }
                Console.WriteLine(counter);
            }
        }
    }
}
