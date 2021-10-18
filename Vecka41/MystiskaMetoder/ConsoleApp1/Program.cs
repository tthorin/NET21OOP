namespace ConsoleApp1
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            double sträcka = Bromssträcka(259);
            Console.WriteLine($"Bromssträckan är: {sträcka} meter");
        }
        static public double Bromssträcka(double hastighet)
        {
            double friktion = 0.8;
            double sträcka = Math.Pow(hastighet, 2.0) / (250 * friktion);
            return sträcka;
        }
    }
}
