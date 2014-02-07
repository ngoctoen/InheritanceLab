using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritanceLab
{
    public class Customer : Person
    {
        private int accountNumber;

        public int AccountNumber
        {
            get
            {
                return accountNumber;
            }
            set
            {
                accountNumber = value;
            }
        }

        public Customer(string lastName, string firstName, int accountNumber)
            : base(firstName, lastName)
        {
            this.accountNumber = accountNumber;
        }

        public override string ToString()
        {
            return base.ToString() + "\t" + accountNumber;
        }

    }
}//end
