using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritanceLab
{
    class Employee : Person
    {
        private string departmentCode;
        private int employeeID;

        public string DepartmentCode
        {
            get
            {
                return departmentCode;
            }
            set
            {
                departmentCode = value;
            }
        }

            public int EmployeeID
            {
                get
                {
                    return employeeID;
                }
                set
                {
                    employeeID = value;
                }
            }

            public Employee(string lastName, string firstName, string departmentCode, int employeeID) : base (lastName,firstName)
    {
        this.departmentCode = departmentCode;
        this.employeeID = employeeID;
    }

            public override string ToString()
            {
               
               return departmentCode + "\t" + base.ToString() + employeeID;
            }
    }
}//end
