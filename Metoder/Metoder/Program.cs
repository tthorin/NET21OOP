﻿

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
            Console.WriteLine($"Kalle har {kalle}");
            Console.WriteLine($"Pelle har {pelle}");
            Console.WriteLine($"Tjalle har {tjalle}");
            Console.WriteLine();

            Console.WriteLine($"Dom betalar {kalle + pelle + tjalle} kr.");
            int kvarEfterKöp = (kalle + pelle + tjalle) - bullar;
            kalle -= 10;
            pelle -= 10;
            tjalle -= 10;

            Console.WriteLine($"Kalle har nu {kalle}.");
            Console.WriteLine($"Pelle har nu {pelle}.");
            Console.WriteLine($"Tjalle har nu {tjalle}.");
            Console.WriteLine($"Och dom får tillbaka {kvarEfterKöp}.");
            Console.WriteLine();

            Console.WriteLine($"De delar så att de får en krona var.");
            kalle++;
            pelle++;
            tjalle++;
            kvarEfterKöp -= 3;
            rödaKorset += kvarEfterKöp;
            Console.WriteLine($"Kalle har nu {kalle}");
            Console.WriteLine($"Pelle har nu {pelle}");
            Console.WriteLine($"Tjalle har nu {tjalle}");
            Console.WriteLine($"Och donerar {kvarEfterKöp} till Röda korset");
            kvarEfterKöp = 0;
            Console.WriteLine();

            Console.WriteLine($"Summa summarum:");
            //int utlägg = (10 - 1) * 3;
            //Console.WriteLine($"De betalade 10 - 1 kronor var, alltså 9*3 = {utlägg} kronor");
            //Console.WriteLine($"och donerade 2 kronor");
            //utlägg += 2;
            //Console.WriteLine($"Summan blir då: {utlägg}");
            //if (utlägg != 30) Console.WriteLine($"Error 404: Krona not found");
            double utlägg = 25d / 3d;
            Console.WriteLine(utlägg);


            Console.WriteLine("\nVad som händer är att dom försöker dela sin växel jämt mellan sig, men");
            Console.WriteLine("man kan inte dela 5 enkronor jämt på 3 personer.");
        }
    }
}
