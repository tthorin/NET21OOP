namespace DebitKredit
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        
        static void Main(string[] args)
        {
            Accounting bok = new();

            bok.CreateTransaction(5410, 10000, 0);
            bok.CreateTransaction(1930, 0, 10000);
            bok.CreateTransaction(3010, 100, 100);
            bok.CreateTransaction(2440, 0, 0);
            bok.CreateTransaction(5410, 0, -10000);
            bok.CreateTransaction(1111, 0, -10000);

            bok.PrintAll();
            decimal debit = bok.SumDebit();
            decimal credit = bok.SumCredit();
            
            Console.WriteLine("Summa Debet: " + debit);
            Console.WriteLine("Summa Kredit: " + credit);
            Console.WriteLine("Resultat skillnad: " + (debit - credit));
        }
    }
}
