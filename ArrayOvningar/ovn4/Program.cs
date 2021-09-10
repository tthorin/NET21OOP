using System;

namespace ovn4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new();

            Console.Write("Vad heter du? ");
            string name = Console.ReadLine().Trim();
            char[] nameArr = name.ToCharArray();

            for (int i = 0; i < 10; i++)
            {
                int random1 = rng.Next(1, nameArr.Length);
                int random2 = rng.Next(1, nameArr.Length);
                char tmp = nameArr[random1];
                nameArr[random1] = nameArr[random2];
                nameArr[random2] = tmp;
            }
            Console.WriteLine(nameArr);
        }
    }
}
