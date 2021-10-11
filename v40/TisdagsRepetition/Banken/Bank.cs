namespace Banken
{
    using System;
    public class Bank
    {
        public Account Account { get; set; } = new();
        public CreditCard Card { get; set; } = new();
        public SavingsAccount Savings { get; set; } = new();
        public LongTermSavings LongTerm { get; set; } = new();

        public void PrintAllBalance()
        {
            Console.WriteLine("Konto: " + Account.Balance);
            Console.WriteLine("Kort: " + Card.Balance);
            Console.WriteLine("Spar: " + Savings.Balance);
            Console.WriteLine("Långtids: " + LongTerm.Balance);
        }

    }
}
