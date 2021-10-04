namespace RadRaknare
{
    using System;

    class Program
    {
        static void Main()
        {
            string text = "";
            for (int i = 1; i < 11; i++)
            {
                text += i.ToString()+" ";
                Console.WriteLine(text);
            }

            /*
            for (int tal = 1; tal < 11; tal++)
            {
                for (int multi = 1; multi < tal; multi++)
                {
                    Console.Write(multi + " ");
                }
                Console.WriteLine();
            }
             */
        }
    }
}
