using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPVApp
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            titleLabel.Text = "Program 2";
            byLabel.Text = "By: C9519";
            courseLabel.Text = "CIS 200-01";
            semesterLabel.Text = "Fall 2016";
            dueDateLabel.Text = "Due: 1 November 2016";
        }

        // Precondition:  User has initiated click on OK
        // Postcondition: Form is dismissed with OK result sent to Program2Form
        private void okButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
