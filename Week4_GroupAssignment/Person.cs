using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_GroupAssignment
{
    public class Person
    {
        private string password;
        public bool IsAuthenticated { get; private set; }
        public string SIN { get; }
        public string Name { get; }

        public Person(string name, string sin)
        {
            Name = name;
            SIN = sin;
        }
        public void Login(string password)
        {
            this.password = password;
            if (this.password != password)
            {
                IsAuthenticated = false;
                throw new AccountException(ExceptionType.PASSWORD_INCORRECT);
            }
            else
            {
                IsAuthenticated = true;
            }
        }
        public void Logout()
        {
            IsAuthenticated = false;
        }
        public override string ToString()
        {
            return $"User Name: {Name}";
        }
    }

}
