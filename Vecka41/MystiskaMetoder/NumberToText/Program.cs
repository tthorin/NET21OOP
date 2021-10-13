namespace NumberToText
{
    using System;
    enum Numbers
    {
        Noll,
        Ett, 
        Två,
        Tre,
        Fyra,
        Fem,
        Sex,
        Sju,
        Åtta,
        Nio
    }

    class Program
    {
        static void Main(string[] args)
        {
                       //9223372036854775807
            NumberToText(1211253453463463463);
        }
        static void NumberToText(long number)
        {
            string numberString = number.ToString();
            for (int i = 0; i < numberString.Length; i++)
            {
                Console.Write((Numbers)int.Parse(numberString[i].ToString())+" ");
            }
        }
    }
}
