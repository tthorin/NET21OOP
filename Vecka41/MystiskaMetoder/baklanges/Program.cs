namespace baklanges
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Backwards("paris");
        }
        static public void Backwards(string text)
        {
            string backWardsText = "";
            for (int letter = text.Length-1; letter >= 0; letter--)
            {
                backWardsText += text[letter];
            }
            Console.WriteLine($"{text} baklänges blir: {backWardsText}");
        }
    }
}
