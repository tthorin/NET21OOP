namespace DebitKredit
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            Accounting bok = new();

            bok.CreateTransaction(1910, 0, 5000);
            bok.CreateTransaction(2440, 5000, 0);

            decimal debit = 0;
            decimal credit = 0;

            foreach (var trans in bok.Transactions)
            {
                Console.WriteLine("Konto: " + trans.Number + " " + trans.Label);
                Console.WriteLine(" " + trans.Debit);
                Console.WriteLine(" "+ trans.Credit);
                debit += trans.Debit;
                credit += trans.Credit;
            }
            Console.WriteLine("Summa Debet: " + debit);
            Console.WriteLine("Summa Kredit: " + credit);
            Console.WriteLine("Resultat skillnad: " + (debit - credit));
        }
    }
}
