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
    public partial class frmPersonMaintenance : Form
    {
        public frmPersonMaintenance()
        {
            InitializeComponent();
        }

        

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPersonMaintenance_Load(object sender, EventArgs e)
        {
       
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
           
        }

        private void btnDisplayCustomer_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "";
            int num = 0;
            foreach(Customer c)
            {
                if(c.GetType().Name.Equals("Customer"))
                {
                    txtOutput.Text = c.ToString() + "\r\n";
                    num ++;
                }

                txtOutput.Text = "There are " + num + " customers";
            }
        }
    }
}
