namespace Banken
{
    using System;
    public class CreditCard :Account
    {
        public string CardNumber { get; private set; } = "";
        public decimal Credit { get; private set; } = 0;

        public CreditCard()
        {
            Name = "CreditCardDefaultName";
        }
        public override void Withdraw(decimal amount)
        {   
            if (amount <= Balance+Credit)
            {
                if (amount >= moneyMoveLimit) NotifyIRS = true;
                Balance -= amount;
                Console.WriteLine($"Du tog ut {amount} kr från {Name}, det nya saldot är {Balance} kr och du kan nyttja {(Balance<0?$"{Credit-Math.Abs(Balance)} kr till ":$"{Credit} kr")} på kredit.");
            }
            else
            {
                Console.WriteLine($"Du kan inte ta ut {amount} kr från {Name}, du har bara {Balance+Credit} kr att nyttja på kontot.");
            }
        }
        public void SetCredit(decimal newLimit)
        {
            Credit = newLimit;
        }
    }
}
