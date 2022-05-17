using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Week4_GroupAssignment
{
    public abstract class Account
    {
        private static int LAST_NUMBER = 100_000;
        public readonly List<Person> users;
        public readonly List<Transaction> transactions;

        public double Balance { get; protected set; }
        public double LowestBalance { get; protected set; }
        public string Number { get; protected set; }

        public Account(string type, double balance)
        {
            Number = type + LAST_NUMBER.ToString();
            LAST_NUMBER++;
            Balance = balance;
            LowestBalance = balance;
            transactions = new List<Transaction>();
            users = new List<Person>();
        }

        public virtual void Deposit(double amount, Person person)
        {
            this.Balance = this.Balance + amount;
            this.LowestBalance = this.Balance;
            var transaction = new Transaction(Number, Utils.Time, amount, person);
            transactions.Add(transaction);
        }

        public void AddUser(Person person)
        {
            users.Add(person);
        }

        public bool IsUser(string name)
        {
            foreach (var user in users)
            {
                if (user.Name == name)
                    return true;
            }
            return false;
        }

        public abstract void PrepareMonthlyReport();
        public virtual void OnTransactionOccur(object sender, EventArgs args)
        {
            EventHandler handler = OnTransactionOccur;
            handler?.Invoke(sender, args);
        }

        public override string ToString()
        {
            string result = "Account number: " + Number + ". Users: ";
            foreach (var user in users)
            {
                result += user.Name + ", ";
            }

            result += ". Balance: " + Balance + ". Transactions: ";
            foreach (var trans in transactions)
            {
                result += trans.Time.ToString() + ", ";
            }
            return result;

        }

        internal void OnTransactionOccur(Action<object, TransactionEventArgs> transactionHandler)
        {
            throw new NotImplementedException();
        }
    }

}
