namespace Banken
{
    using System;
    public class LongTermSavings : Account
    {
        public int WithdrawalsThisYear { get; set; } = 0;
        public int WithdrawalsAllowedPerYear { get; set; } = 3;
        private int thisYear = 0;

        public LongTermSavings()
        {
            Name = "LongTermSavingsDefaultName";
            thisYear = DateTime.Now.Year;
        }
        public override void Withdraw(decimal amount)
        {
            if (thisYear != DateTime.Now.Year)
            {
                thisYear = DateTime.Now.Year;
                WithdrawalsThisYear = 0;
            }
            if (WithdrawalsThisYear < WithdrawalsAllowedPerYear)
            {
                decimal tempValue = Balance;
                base.Withdraw(amount);
                if (tempValue != Balance) WithdrawalsThisYear++;
            }
            else Console.WriteLine($"Du har redan tagit ut från detta konto {WithdrawalsAllowedPerYear} gånger i år, antingen vänta tills nästa år eller kontakta banken för mer information.");
        }

    }
}
