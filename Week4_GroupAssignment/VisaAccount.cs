using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_GroupAssignment
{
    public class VisaAccount : Account, ITransaction
    {
        private double creditLimit;
        private static double INTEREST_RATE = 0.1995;

        public VisaAccount(double balance = 0, double creditLimit = 1200) : base("VS-", balance)
        {
            this.creditLimit = creditLimit;
        }

        public void DoPayment(double amount, Person person)
        {
            base.Deposit(amount, person);
        }
        public void DoPurchase(double amount, Person person)
        {
            if (!this.IsUser(person.Name)) throw new AccountException(ExceptionType.NAME_NOT_ASSOCIATED_WITH_ACCOUNT);
            if (!person.IsAuthenticated) throw new AccountException(ExceptionType.USER_NOT_LOGGED_IN);
            if (amount > this.Balance) throw new AccountException(ExceptionType.CREDIT_LIMIT_HAS_BEEN_EXCEEDED);
            this.Deposit(-amount, person);
        }
        public override void PrepareMonthlyReport()
        {
            double interest = LowestBalance * (INTEREST_RATE / 12);
            this.Balance -= interest;
            this.transactions.Clear();
        }
        public void Withdraw(double amount, Person person)
        { }
    }

}
