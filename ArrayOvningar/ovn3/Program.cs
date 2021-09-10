using System;

namespace ovn3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vad heter du? ");
            string name = Console.ReadLine().Trim();
            string backwards = "";
            

            for (int i = name.Length -1; i >= 0; i--)
            {
                backwards += name[i];
            }
            Console.Write("Ditt namn baklänges blir: "+backwards);
        }
    }
}
