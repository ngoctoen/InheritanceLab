using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InheritanceLab
{
    public partial class frmAddCustomer : Form
    {
        public frmAddCustomer()
        {
            InitializeComponent();
        }
        private List<Person> people;

        private void frmAddCustomer_Load(object sender, EventArgs e)
        {
            people = new List<Person>();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Customer tempCustomer;

            tempCustomer = new Customer(txtLastName.Text, txtFirstName.Text, Convert.ToInt32(txtAccountNumber.Text));
            this.Tag = tempCustomer;
            DialogResult = DialogResult.OK;

            frmAddCustomer addCustomerForm;
            DialogResult returnCode;

            addCustomerForm = new frmAddCustomer();
            returnCode = addCustomerForm.ShowDialog();
            if (returnCode == DialogResult.OK)
            {
                people.Add((Customer)addCustomerForm.Tag);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

      
    }
}
