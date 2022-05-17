using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_GroupAssignment
{
    public class LoginEventArgs : EventArgs
    {
        public string PersonName { get; }

        public bool Success { get; }

        public LoginEventArgs(string personName, bool success) : base()
        {
            PersonName = personName;
            Success = success;
        }
    }

}
