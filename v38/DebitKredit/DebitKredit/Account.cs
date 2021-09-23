namespace DebitKredit
{
    using System;
    public class Account
    {
        private string label;
        private int number;
        private decimal debit;
        private decimal credit;

        public string Label
        {
            get { return label; }
            set { label = value; }
        }
        public int Number { get => number; set => number = value; }
        public decimal Debit { get => debit; set => debit = value; }
        public decimal Credit { get => credit; set => credit = value; }
    }
}