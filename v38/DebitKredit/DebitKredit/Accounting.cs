using System;
using System.Collections.Generic;

namespace DebitKredit
{
    public class Accounting
    {
        public List<Transaction> Transactions { get; set; } = new List<Transaction>();
        public Dictionary<int, string> ChartOfAccounts = new Dictionary<int, string>();

        public Accounting()
        {
            ChartOfAccounts.Add(1910, "Kassa");
            ChartOfAccounts.Add(1930, "Företagskonto");
            ChartOfAccounts.Add(2440, "Leverantörsskuld");
            ChartOfAccounts.Add(3010, "Försäljning");
            ChartOfAccounts.Add(5410, "Datorinköp");
        }


        public void CreateTransaction (int accountNr, decimal debit,decimal credit)
        {
            Transactions.Add
                (
                    new Transaction { Number = accountNr, Label = ChartOfAccounts[accountNr], Credit = credit, Debit = debit }
                );
        }
    }
}
