using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Week4_GroupAssignment
{
    [Serializable]
    public class AccountException : Exception
    {
        public AccountException()
        {
        }

        public AccountException(ExceptionType reason) : base(reason.ToString())
        {
        }



        public AccountException(string message) : base(message)
        {
        }

        public AccountException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected AccountException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }

}
