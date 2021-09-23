namespace DebitKredit
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            List<Account> transactions = new();
            Account acc = new();
            acc.Number = 1910;
            acc.Label = "Kassa";
            acc.Credit = 5000;

            transactions.Add(acc);
            
            acc = new Account();
            acc.Number = 2440;
            acc.Label = "Lev.skuld";
            acc.Debit = 5000;

            transactions.Add(acc);

            decimal debit = 0;
            decimal credit = 0;

            foreach (var trans in transactions)
            {
                Console.WriteLine("Konto: " + trans.Number + " " + trans.Label);
                Console.WriteLine(" " + trans.Debit);
                Console.WriteLine(" "+ trans.Credit);
                debit += trans.Debit;
                credit += trans.Credit;
            }
        }
    }
}
