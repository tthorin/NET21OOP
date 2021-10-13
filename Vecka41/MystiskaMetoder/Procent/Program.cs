namespace Procent
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            ProcentAv(10, 100);
            HowManyPercent(10, 200);
        }
        static public void ProcentAv(double proc, double value)
        {
            double percent = Math.Round((proc / 100 * value), 2);
            double total = value + percent;
            Console.WriteLine(total);
        }
        static public void HowManyPercent (double num, double value)
        {
            double percent = (num / value) * 100;
            Console.WriteLine($"{num} är {percent} % av {value}");
        }
    }
}
