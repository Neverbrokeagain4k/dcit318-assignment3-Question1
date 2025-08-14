using System;

namespace DCIT318_Assignment.Question1
{
    // Question 1c: Create concrete classes implementing ITransactionProcessor
    public class BankTransferProcessor : ITransactionProcessor
    {
        public void Process(Transaction transaction)
        {
            Console.WriteLine($"Processing Bank Transfer: Amount ${transaction.Amount:F2} for {transaction.Category}");
        }
    }

    public class MobileMoneyProcessor : ITransactionProcessor
    {
        public void Process(Transaction transaction)
        {
            Console.WriteLine($"Processing Mobile Money: Amount ${transaction.Amount:F2} for {transaction.Category}");
        }
    }

    public class CryptoWalletProcessor : ITransactionProcessor
    {
        public void Process(Transaction transaction)
        {
            Console.WriteLine($"Processing Crypto Wallet: Amount ${transaction.Amount:F2} for {transaction.Category}");
        }
    }
}