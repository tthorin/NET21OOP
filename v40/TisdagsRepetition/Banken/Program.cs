namespace Banken
{
    using System;

    class Program
    {
        static void Main()
        {
            Bank handelsSweDea = new();
            handelsSweDea.Card.SetCredit(5000);
            handelsSweDea.Card.Deposit(400);
            handelsSweDea.Card.Withdraw(1200);
            Console.WriteLine(handelsSweDea.Card.Name + " saldo: " + handelsSweDea.Card.Balance);
            handelsSweDea.Savings.Deposit(500);
            handelsSweDea.LongTerm.Deposit(1200);
            handelsSweDea.LongTerm.Withdraw(300);
            handelsSweDea.LongTerm.Withdraw(100);
            handelsSweDea.LongTerm.Withdraw(500);
            handelsSweDea.LongTerm.Withdraw(300);

            handelsSweDea.PrintAllBalance();

            Console.WriteLine();
        }

    }
}
