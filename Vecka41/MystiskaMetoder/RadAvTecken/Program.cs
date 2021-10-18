namespace RadAvTecken
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RadAvTecken('*',3));
        }
        static string RadAvTecken (char symbol, int antal)
        {
            return new string(symbol, antal);
        }

        
    }
}
