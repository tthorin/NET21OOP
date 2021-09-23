namespace DebitKredit
{
    using System;
    public class Transaction
    {
        public string Label { get; }
        public int Number { get; }
        public decimal Debit { get; }
        public decimal Credit { get; }
        public DateTime Time { get; }

        public Transaction(int accountNr, string label, decimal debit, decimal credit)
        {
            this.Number = accountNr;
            this.Label = label;
            this.Credit = credit;
            this.Debit = debit;
            this.Time = DateTime.Now;
        }
        public override string ToString()
        {
            return $"{Time.ToString("yyyy-MM-dd HH:mm")} | {Number:0000} | {Label,-20} | {Debit,7} | {Credit,7} |";
        }
    }
}