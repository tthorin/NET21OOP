namespace Banken
{
    using System;
    public class SavingsAccount:Account
    {
        public decimal Intrest { get; set; } = 0;

        public SavingsAccount()
        {
            Name = "SavingsAccountDefaultName";
        }

    }
}
