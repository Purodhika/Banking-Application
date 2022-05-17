using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_GroupAssignment
{
    internal class CheckingAccount : Account, ITransaction
    {
        private static double COST_PER_TRANSACTION = 0.05;
        private static double INTEREST_RATE = 0.005;
        private bool hasOverdraft;

        public CheckingAccount(double balance = 0, bool hasOverdraft = false) : base("CK-", balance)
        {
            this.hasOverdraft = hasOverdraft;
        }
        public new void Deposit(double amount, Person person)
        {
            base.Deposit(amount, person);
            base.OnTransactionOccur(amount, new TransactionEventArgs(person.Name, amount, true));
        }

        public void Withdraw(double amount, Person person)
        { }


        public override void PrepareMonthlyReport()
        {
            var serviceFee = transactions.Count * COST_PER_TRANSACTION;
            var interest = base.Balance * (INTEREST_RATE / 12);
            this.Balance += this.Balance + interest - serviceFee;
            this.transactions.Clear();
        }
    }

}
