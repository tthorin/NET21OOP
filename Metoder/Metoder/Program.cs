

namespace DenSaknadeKronan
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int bullar = 25;
            int kalle = 10;
            int pelle = 10;
            int tjalle = 10;
            int rödaKorset = 0;

            Console.WriteLine($"Bullarna kostar {bullar}");
            moneyStatus(kalle, pelle, tjalle);

            Console.WriteLine($"Dom betalar {kalle + pelle + tjalle} kr.");
            int kvarEfterKöp = (kalle + pelle + tjalle) - bullar;
            kalle -= 10;
            pelle -= 10;
            tjalle -= 10;

            moneyStatus(kalle, pelle, tjalle);
            Console.WriteLine($"Och dom får tillbaka {kvarEfterKöp}.");
            Console.WriteLine();

            Console.WriteLine($"De delar så att de får en krona var.");
            kalle++;
            pelle++;
            tjalle++;
            kvarEfterKöp -= 3;
            rödaKorset += kvarEfterKöp;
            moneyStatus(kalle, pelle, tjalle);
            Console.WriteLine($"Och donerar {kvarEfterKöp} till Röda korset");
            kvarEfterKöp = 0;
            Console.WriteLine();

            Console.WriteLine($"Summa summarum:");
            double utlägg = (25d / 3d) * 3d;
            Console.WriteLine($"De betalade 25 / 3 kronor var, alltså {25d / 3d} * 3 = {utlägg} kronor");
            Console.WriteLine("Och tog en enkrona var från växeln (1*3=3)");
            utlägg += 3;
            Console.WriteLine($"och donerade 2 kronor");
            utlägg += 2;
            Console.WriteLine($"Summan blir då: {utlägg}");
            if (utlägg != 30) Console.WriteLine($"Error 404: Krona not found");


        }

        private static void moneyStatus(int kalle, int pelle, int tjalle)
        {
            Console.WriteLine($"Kalle har {kalle}");
            Console.WriteLine($"Pelle har {pelle}");
            Console.WriteLine($"Tjalle har {tjalle}");
            Console.WriteLine();
        }
    }
}
