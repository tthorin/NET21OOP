namespace Banken
{
    using System;
    public class Account
    {
        public decimal Balance { get; protected set; } = 0;
        public string Name { get; protected set; } = "Konto";
        public string Number { get; protected set; } = "";
        public bool NotifyIRS { get; protected set; } = false;
        protected int moneyMoveLimit = 10000;

        public virtual void Withdraw(decimal amount)
        {

            if (amount <= Balance)
            {
                if (amount >= moneyMoveLimit) NotifyIRS = true;
                Balance -= amount;
                Console.WriteLine($"Du tog ut {amount} kr från {Name}, det nya saldot är {Balance} kr");
            }
            else
            {
                Console.WriteLine($"Du kan inte ta ut {amount} kr från {Name}, du har bara {Balance} kr på kontot.");
            }
        }
        public virtual void Deposit(decimal amount)
        {
            if (amount >= 10000) NotifyIRS = true;
            Balance += amount;
            Console.WriteLine($"Du satte in {amount} kr på konto {Name}, det nya saldot är: {Balance} kr.");
        }
        public void ReviewAccount()
        {
            Console.WriteLine($"Kontroll av kontonummer: {Number}, kontonamn: {Name} - OK.");
            NotifyIRS = false;
        }

    }
}
