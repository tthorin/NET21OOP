using System;
using System.Collections.Generic;
using System.IO;

namespace DebitKredit
{
    public class Accounting
    {
        private List<Transaction> transactions = new List<Transaction>();
        private List<string> failedTransactions = new();
        public Dictionary<int, string> ChartOfAccounts = new Dictionary<int, string>();
        private string logFile = "log.txt";
        int recjectedTransactions = 0;

        public Accounting()
        {
            ChartOfAccounts.Add(1910, "Kassa");
            ChartOfAccounts.Add(1930, "Företagskonto");
            ChartOfAccounts.Add(2440, "Leverantörsskuld");
            ChartOfAccounts.Add(3010, "Försäljning");
            ChartOfAccounts.Add(5410, "Datorinköp");
        }


        /// <summary>
        /// Creates a new transaction
        /// </summary>
        /// <param name="accountNr">
        /// 1910: Kassa,
        /// 1930: Företagskonto,
        /// 2440: Leverantörsskuld,
        /// 3010: Försäljning,
        /// 5410: Datorinköp
        /// </param>
        /// <param name="debit"></param>
        /// <param name="credit"></param>
        public void CreateTransaction(int accountNr, decimal debit, decimal credit)
        {
            string TransactionValidation = ValidateTransaction(accountNr, debit, credit);

            if (TransactionValidation == "OK")
            {
                Transaction trans = new Transaction(accountNr, ChartOfAccounts[accountNr], credit, debit);
                transactions.Add(trans);
                LogTransaction(trans);
            }
            else
            {
                LogTransaction(accountNr, debit, credit, TransactionValidation);
            }
        }

        private void LogTransaction(int accountNr, decimal debit, decimal credit, string transactionValidation)
        {
            string label = "";
            if (ChartOfAccounts.ContainsKey(accountNr)) label = ChartOfAccounts[accountNr];
            string logText = $"{DateTime.Now.ToString("yyyy-MM-dd HH:mm")} : {accountNr:0000} : {label,-20} : {debit,7} : {credit,7} :";
            failedTransactions.Add(logText + " Rejected.");
            File.AppendAllText(logFile, logText + $" {transactionValidation}\r\n");
            recjectedTransactions++;
        }

        private void LogTransaction(Transaction trans)
        {
            File.AppendAllText(logFile, trans.ToString() + "\r\n");
        }

        private string ValidateTransaction(int accountNr, decimal debit, decimal credit)
        {
            string result = "";
            if (!ChartOfAccounts.ContainsKey(accountNr))
            {
                result = "Rejected, no such account found.";
            }
            else if (debit < 0 || credit < 0)
            {
                result = "Rejected, transaction can not have a negative value.";
            }
            else if (debit == 0 && credit == 0)
            {
                result = "Rejected, both credit and debit can not be zero.";
            }
            else if (debit > 0 && credit > 0)
            {
                result = "Rejected, both credit and debit can not have a value in the same transaction.";
            }
            else result = "OK";

            return result;
        }
        public decimal SumDebit()
        {
            decimal sumDebit = 0;
            foreach (var transaction in transactions)
            {
                sumDebit += transaction.Debit;
            }
            return sumDebit;
        }
        public decimal SumCredit()
        {
            decimal sumCredit = 0;
            foreach (var transaction in transactions)
            {
                sumCredit += transaction.Credit;
            }
            return sumCredit;
        }
        public void PrintAll()
        {
            foreach (var trans in transactions)
            {
                Console.WriteLine(trans.ToString());
            }
            if (recjectedTransactions > 0)
            {
                Console.WriteLine(recjectedTransactions + " rejected transactions:");
                foreach (var failed in failedTransactions)
                {
                    Console.WriteLine(failed);
                }
            }
            Console.WriteLine("\nAll transactions logged (including reasons for rejection) in " + logFile + ".\n");
        }
        public void PrintAccount(int accountNumber)
        {
            foreach (var trans in transactions)
            {
                if (trans.Number == accountNumber)
                    Console.WriteLine(trans.ToString());
            }
        }
    }
}
