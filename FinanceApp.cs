using System;
using System.Collections.Generic;

namespace DCIT318_Assignment.Question1
{
    // Question 1f: Create FinanceApp class
    public class FinanceApp
    {
        private List<Transaction> _transactions;

        public FinanceApp()
        {
            _transactions = new List<Transaction>();
        }

        public void Run()
        {
            // i. Instantiate SavingsAccount
            var savingsAccount = new SavingsAccount("SAV001", 1000m);
            Console.WriteLine($"Initial balance: ${savingsAccount.Balance:F2}");

            // ii. Create three Transaction records
            var transaction1 = new Transaction(1, DateTime.Now, 150m, "Groceries");
            var transaction2 = new Transaction(2, DateTime.Now, 80m, "Utilities");
            var transaction3 = new Transaction(3, DateTime.Now, 200m, "Entertainment");

            // iii. Use processors to process each transaction
            var mobileProcessor = new MobileMoneyProcessor();
            var bankProcessor = new BankTransferProcessor();
            var cryptoProcessor = new CryptoWalletProcessor();

            mobileProcessor.Process(transaction1);
            bankProcessor.Process(transaction2);
            cryptoProcessor.Process(transaction3);

            // iv. Apply each transaction to SavingsAccount
            savingsAccount.ApplyTransaction(transaction1);
            savingsAccount.ApplyTransaction(transaction2);
            savingsAccount.ApplyTransaction(transaction3);

            // v. Add all transactions to _transactions
            _transactions.Add(transaction1);
            _transactions.Add(transaction2);
            _transactions.Add(transaction3);

            Console.WriteLine($"Total transactions processed: {_transactions.Count}");
        }
    }
}