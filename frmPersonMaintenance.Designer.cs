namespace InheritanceLab
{
    partial class frmPersonMaintenance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnDisplayCustomer = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnDisplayEmployees = new System.Windows.Forms.Button();
            this.btnDisplayAllPeople = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(24, 12);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(114, 23);
            this.btnAddCustomer.TabIndex = 0;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnDisplayCustomer
            // 
            this.btnDisplayCustomer.Location = new System.Drawing.Point(24, 41);
            this.btnDisplayCustomer.Name = "btnDisplayCustomer";
            this.btnDisplayCustomer.Size = new System.Drawing.Size(114, 23);
            this.btnDisplayCustomer.TabIndex = 1;
            this.btnDisplayCustomer.Text = "Display Cutomers";
            this.btnDisplayCustomer.UseVisualStyleBackColor = true;
            this.btnDisplayCustomer.Click += new System.EventHandler(this.btnDisplayCustomer_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(24, 90);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(114, 23);
            this.btnAddEmployee.TabIndex = 2;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            // 
            // btnDisplayEmployees
            // 
            this.btnDisplayEmployees.Location = new System.Drawing.Point(24, 119);
            this.btnDisplayEmployees.Name = "btnDisplayEmployees";
            this.btnDisplayEmployees.Size = new System.Drawing.Size(114, 23);
            this.btnDisplayEmployees.TabIndex = 3;
            this.btnDisplayEmployees.Text = "Display Employees";
            this.btnDisplayEmployees.UseVisualStyleBackColor = true;
            // 
            // btnDisplayAllPeople
            // 
            this.btnDisplayAllPeople.Location = new System.Drawing.Point(24, 157);
            this.btnDisplayAllPeople.Name = "btnDisplayAllPeople";
            this.btnDisplayAllPeople.Size = new System.Drawing.Size(114, 23);
            this.btnDisplayAllPeople.TabIndex = 4;
            this.btnDisplayAllPeople.Text = "Display All People";
            this.btnDisplayAllPeople.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(41, 201);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(144, 12);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(280, 212);
            this.txtOutput.TabIndex = 6;
            // 
            // frmPersonMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 236);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDisplayAllPeople);
            this.Controls.Add(this.btnDisplayEmployees);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.btnDisplayCustomer);
            this.Controls.Add(this.btnAddCustomer);
            this.Name = "frmPersonMaintenance";
            this.Text = "Person Maintenance";
            this.Load += new System.EventHandler(this.frmPersonMaintenance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnDisplayCustomer;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnDisplayEmployees;
        private System.Windows.Forms.Button btnDisplayAllPeople;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtOutput;
    }
}

