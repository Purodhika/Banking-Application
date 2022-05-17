using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_GroupAssignment
{
    public class TransactionEventArgs : LoginEventArgs
    {
        public double Amount { get; }
        public string Operation { get; internal set; }

        public TransactionEventArgs(string personName, double amount, bool success) : base(personName, success)
        {
            Amount = amount;
        }
    }

}
