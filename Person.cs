using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritanceLab
{
    class Person
    {
        private string firstName, lastName;

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return LastName;
            }
            set
            {
                lastName = value;
            }
        }

        public Person(String firstName, String lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public override string ToString()
        {
            return firstName + " " + lastName;
        }

    }
}//end
