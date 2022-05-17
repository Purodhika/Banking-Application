using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_GroupAssignment
{
    public class Transaction
    {

        public string AccountNumber { get; }
        public double Amount { get; }
        public Person Originator { get; }
        public DayTime Time { get; }


        public Transaction(string accountNumber, DayTime time, double amount, Person person)
        {
            AccountNumber = accountNumber;
            Amount = amount;
            Originator = person;
            Time = time;
        }
        public override string ToString()//get this corrected after code completion
        {
            string action = (Amount > 0) ? action = "Deposited" : action = "Withdrawn";
            return $"{AccountNumber}{Originator.Name}{action}{Amount.ToString()}";
            //$",{Time.ToShortTimeString()}";
        }

    }

}
