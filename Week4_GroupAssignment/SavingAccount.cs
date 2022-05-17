using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_GroupAssignment
{
    internal class SavingAccount : Account, ITransaction
    {
        private static double COST_PER_TRANSACTION = 0.05;
        private static double INTEREST_RATE = 0.015;

        public SavingAccount(double balance = 0) : base("SV-", balance)
        {
            Balance = balance;
        }

        public new void Deposit(double amount, Person person)
        {
            base.Deposit(amount, person);
        }

        public void Withdraw(double amount, Person person)
        {
            if (!this.IsUser(person.Name)) throw new AccountException(ExceptionType.NAME_NOT_ASSOCIATED_WITH_ACCOUNT);
            if (!person.IsAuthenticated) throw new AccountException(ExceptionType.USER_NOT_LOGGED_IN);
            if (this.Balance < amount) throw new AccountException(ExceptionType.CREDIT_LIMIT_HAS_BEEN_EXCEEDED);
            base.Deposit(-amount, person);
        }

        public override void PrepareMonthlyReport()
        {
            var serviceFee = this.transactions.Count * COST_PER_TRANSACTION;
            var interest = this.LowestBalance * (INTEREST_RATE / 12);
            this.Balance += interest - serviceFee;
            this.transactions.Clear();
        }
    }

}
