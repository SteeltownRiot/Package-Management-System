/*
 * C9519
 * Program2
 * 1 November 2016
 * CIS 200-01
 * Adds letters to the upv address list
*/
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
    public partial class AddLetterForm : Form
    {
        public AddLetterForm(List<Address> addressList)
        {
            AddressList = addressList;
            InitializeComponent();
        }

        internal int AddOriginAddress
        {
            // Precondition:  None
            // Postcondition: The letter's origin address has been returned
            get { return oAddressComboBox.SelectedIndex; }
        }

        internal int AddDestinationAddress
        {
            // Precondition:  None
            // Postcondition: The letter's destination address has been returned
            get { return dAddressComboBox.SelectedIndex; }
        }

        internal decimal AddFixedCost
        {
            // Precondition:  None
            // Postcondition: The letter's fixed cost has been returned
            get { return decimal.Parse(fixedCostTextBox.Text); }
        }

        private List<Address> AddressList
        {
            // Precondition:  None
            // Postcondition: The upv's address list has been returned
            get;
            // Precondition:  Must be a list of address objects
            // Postcondition: The AddressList is set to the specified value
            set;
        }

        // Precondition:  oAddressComboBox_Validating succeeded
        // Postcondition: Any error message set for inputTxt is cleared
        //                Focus is allowed to change
        private void oAddressComboBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(oAddressComboBox, ""); // Clears error message
        }

        // Precondition:  Attempting to change focus from oAddressComboBox
        // Postcondition: If selected value is valid, focus will change, else
        //                focus will remain and error provider message set
        private void oAddressComboBox_Validating(object sender, CancelEventArgs e)
        {
            // Checks to see if an address was chosen
            if (oAddressComboBox.SelectedIndex < 0)
            {
                e.Cancel = true; // Stops focus changing process
                                 // Will NOT proceed to Validated event

                errorProvider1.SetError(oAddressComboBox, "Pick a destination address."); // Set error message

                oAddressComboBox.SelectAll(); // Select all text in inputTxt to ease correction
            }
            else
            {
                if (oAddressComboBox.SelectedIndex == dAddressComboBox.SelectedIndex)
                {
                    e.Cancel = true; // Stops focus changing process
                                     // Will NOT proceed to Validated event

                    errorProvider1.SetError(oAddressComboBox, "Pick a different address."); // Set error message

                    oAddressComboBox.SelectAll(); // Select all text in inputTxt to ease correction
                }
            }
        }

        // Precondition:  dAddressComboBox_Validating succeeded
        // Postcondition: Any error message set for inputTxt is cleared
        //                Focus is allowed to change
        private void dAddressComboBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(dAddressComboBox, ""); // Clears error message
        }


        // Precondition:  Attempting to change focus from dAddressComboBox
        // Postcondition: If selected value is valid, focus will change, else
        //                focus will remain and error provider message set
        private void dAddressComboBox_Validating(object sender, CancelEventArgs e)
        {
            // Checks to see if an address was chosen
            if (dAddressComboBox.SelectedIndex < 0)
            {
                e.Cancel = true; // Stops focus changing process
                                 // Will NOT proceed to Validated event

                errorProvider1.SetError(dAddressComboBox, "Pick a destination address."); // Set error message

                dAddressComboBox.SelectAll(); // Select all text in inputTxt to ease correction
            }
            else
            {
                if (oAddressComboBox.SelectedIndex == dAddressComboBox.SelectedIndex)
                {
                    e.Cancel = true; // Stops focus changing process
                                     // Will NOT proceed to Validated event

                    errorProvider1.SetError(dAddressComboBox, "Pick a different address."); // Set error message

                    dAddressComboBox.SelectAll(); // Select all text in inputTxt to ease correction
                }
            }
        }

        // Precondition:  fixedCostTextBox_Validating succeeded
        // Postcondition: Any error message set for inputTxt is cleared
        //                Focus is allowed to change
        private void fixedCostTextBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(fixedCostTextBox, ""); // Clears error message
        }

        // Precondition:  Attempting to change focus from fixedCostTextBox
        // Postcondition: If entered value is valid decimal, focus will change,
        //                else focus will remain and error provider message set
        private void fixedCostTextBox_Validating(object sender, CancelEventArgs e)
        {
            decimal cost; // Value entered into fixedCost

            // Will try to parse text as decimal
            // If fails, TryParse returns false
            // If succeeds, TryParse returns true and cost stores parsed value
            if (!decimal.TryParse(fixedCostTextBox.Text, out cost))
            {
                e.Cancel = true; // Stops focus changing process
                                 // Will NOT proceed to Validated event

                errorProvider1.SetError(fixedCostTextBox, "Enter a decimal."); // Set error message

                fixedCostTextBox.SelectAll(); // Select all text in inputTxt to ease correction
            }
            else
            {
                if (cost < 0)
                {
                    e.Cancel = true; // Stops focus changing process
                                     // Will NOT proceed to Validated event

                    errorProvider1.SetError(fixedCostTextBox, "Enter a non-negative decimal."); // Set error message

                    fixedCostTextBox.SelectAll(); // Select all text in inputTxt to ease correction
                }
            }
        }

        // Precondition:  User has initiated click on addLetterButton
        // Postcondition: All inputs are validated, if valid is dismissed with OK result sent to Program2Form
        private void addLetterButton_Click(object sender, EventArgs e)
        {
            // ValidateChildren will validate all controls on the form
            if (this.ValidateChildren())
                this.DialogResult = DialogResult.OK;
        }

        // Precondition:  User has initiated click on cancelButton
        // Postcondition: If left-click, AddLetterForm is dismissed with Cancel result
        private void cancelButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        // Precondition:  None
        // Postcondition: Combo boxes on form populated with upv's list of addresses
        private void AddLetterForm_Load(object sender, EventArgs e)
        {
            foreach (Address address in AddressList)
            {
                oAddressComboBox.Items.Add(address.Name);
                dAddressComboBox.Items.Add(address.Name);
            }
        }
    }
}