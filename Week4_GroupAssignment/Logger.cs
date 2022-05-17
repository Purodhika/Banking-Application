using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_GroupAssignment
{
    public static class Logger
    {
        private static List<String> loginEvents;
        private static List<String> transactionEvents;

        public static void LoginHandler(object sender, LoginEventArgs args)
        {
            LoginEventArgs eventArgs = args as LoginEventArgs;
            String temp = args.PersonName + args.Success + Utils.Now;
            loginEvents = new List<String>();
            loginEvents.Add(temp);

        }
        public static void TransactionHandler(object sender, TransactionEventArgs args)
        {
            TransactionEventArgs eventArgs = args as TransactionEventArgs;
            String temp = args.PersonName + args.Amount + args.Operation + args.Success + Utils.Now;
            transactionEvents = new List<String>();
            transactionEvents.Add(temp);

        }


        public static void ShowTransactionEvents()
        {
            Console.WriteLine(Utils.Now);
            foreach (string item in transactionEvents)
            {
                Console.WriteLine(item);
            }
        }
        public static void ShowLoginEvents()
        {
            Console.WriteLine(Utils.Now);
            foreach (string item in loginEvents)
            {
                Console.WriteLine(item);
            }
        }

        internal static string LoginHandler(string name, string sin)
        {
            throw new NotImplementedException();
        }
    }

}
