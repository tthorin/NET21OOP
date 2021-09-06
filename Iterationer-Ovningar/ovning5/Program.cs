using System;

namespace ovning5
{
    class Program
    {
        static void Main()
        {
            Console.Write("Vad heter du? ");
            string name = Console.ReadLine();

            string initial = $"{name[0]}";

            int space = 0;
            while (space >= 0)
            {
                space = name.IndexOf(' ', space);
                if (space > 0)
                {
                    space++;
                    initial += name[space];
                }
            }
            Console.WriteLine(initial);
        }
    }
}
