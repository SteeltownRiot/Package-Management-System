/*
 * C9519
 * Program2
 * 1 November 2016
 * CIS 200-01
 * Adds addresses to the upv address list
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
    public partial class addAddressForm : Form
    {
        const int DEFAULT_STATE_INDEX = 16;         // Holds default state's index for stateComboBox

        public addAddressForm()
        {
            InitializeComponent();
        }

        internal string AddName
        {
            // Precondition:  None
            // Postcondition: The address' name has been returned
            get { return nameTextBox.Text; }
        }

        internal string AddAddress1
        {
            // Precondition:  None
            // Postcondition: The address' first address line has been returned
            get { return address1TextBox.Text; }
        }

        internal string AddAddress2
        {
            // Precondition:  None
            // Postcondition: The address' second address line has been returned
            get { return address2TextBox.Text; }
        }

        internal string AddCity
        {
            // Precondition:  None
            // Postcondition: The address' city has been returned
            get { return cityTextBox.Text; }
        }

        internal string AddState
        {
            // Precondition:  None
            // Postcondition: The address' state has been returned
            get { return statesComboBox.Text; }
        }

        internal int AddZip
        {
            // Precondition:  None
            // Postcondition: The address' zip code has been returned
            get
            {
                int zipcode;    // Holds zip code once input has been parsed
                if (int.TryParse(zipTextBox.Text, out zipcode))
                { }
                return zipcode;
            }
        }

        // Precondition:  name_Validating succeeded
        // Postcondition: Any error message set for name is cleared
        //                Focus is allowed to change
        private void name_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(nameTextBox, ""); // Clears error message
        }

        // Precondition:  Attempting to change focus from name
        // Postcondition: If entered value is valid string, focus will change,
        //                else focus will remain and error provider message set
        private void name_Validating(object sender, CancelEventArgs e)
        {
            // Will check to see if there is text
            // If fails, TryParse returns false
            // If succeeds, TryParse returns true and number stores parsed value
            if (nameTextBox.Text == "")
            {
                e.Cancel = true; // Stops focus changing process
                                 // Will NOT proceed to Validated event

                errorProvider1.SetError(nameTextBox, "Enter a name."); // Set error message

                nameTextBox.SelectAll(); // Select all text in inputTxt to ease correction
            }
        }

        // Precondition:  address1_Validating succeeded
        // Postcondition: Any error message set for address1 is cleared
        //                Focus is allowed to change
        private void address1_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(address1TextBox, ""); // Clears error message
        }

        // Precondition:  Attempting to change focus from address1
        // Postcondition: If entered value is valid string, focus will change,
        //                else focus will remain and error provider message set
        private void address1_Validating(object sender, CancelEventArgs e)
        {
            // Will check to see if there is text
            // If fails, TryParse returns false
            // If succeeds, TryParse returns true and number stores parsed value
            if (address1TextBox.Text == "")
            {
                e.Cancel = true; // Stops focus changing process
                                 // Will NOT proceed to Validated event

                errorProvider1.SetError(address1TextBox, "Enter an address."); // Set error message

                address1TextBox.SelectAll(); // Select all text in inputTxt to ease correction
            }
        }

        // Precondition:  city_Validating succeeded
        // Postcondition: Any error message set for city is cleared
        //                Focus is allowed to change
        private void city_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(cityTextBox, ""); // Clears error message
        }

        // Precondition:  Attempting to change focus from city
        // Postcondition: If entered value is valid string, focus will change,
        //                else focus will remain and error provider message set
        private void city_Validating(object sender, CancelEventArgs e)
        {
            // Checks to see if there is text
            if (cityTextBox.Text == "")
            {
                e.Cancel = true; // Stops focus changing process
                                 // Will NOT proceed to Validated event

                errorProvider1.SetError(cityTextBox, "Enter a city."); // Set error message

                cityTextBox.SelectAll(); // Select all text in inputTxt to ease correction
            }
        }

        // Precondition:  statesComboBox_Validating succeeded
        // Postcondition: Any error message set for statesComboBox is cleared
        //                Focus is allowed to change
        private void statesComboBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(statesComboBox, ""); // Clears error message
        }

        // Precondition:  Attempting to change focus from statesComboBox
        // Postcondition: If entered value is valid string, focus will change,
        //                else focus will remain and error provider message set
        private void statesComboBox_Validating(object sender, CancelEventArgs e)
        {
            // Will try to parse text as int
            // If fails, TryParse returns false
            // If succeeds, TryParse returns true and number stores parsed value
            if (statesComboBox.SelectedIndex ==-1)
            {
                e.Cancel = true; // Stops focus changing process
                                 // Will NOT proceed to Validated event

                errorProvider1.SetError(statesComboBox, "Select a state."); // Set error message

                statesComboBox.SelectAll(); // Select all text in inputTxt to ease correction
            }
        }

        // Precondition:  zip_Validating succeeded
        // Postcondition: Any error message set for zip is cleared
        //                Focus is allowed to change
        private void zip_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(zipTextBox, ""); // Clears error message
        }

        // Precondition:  Attempting to change focus from zip
        // Postcondition: If entered value is valid int, focus will change,
        //                else focus will remain and error provider message set
        private void zip_Validating(object sender, CancelEventArgs e)
        {
            int zipcode; // Value entered into zip

            // Will try to parse text as int
            // If fails, TryParse returns false
            // If succeeds, TryParse returns true and number stores parsed value
            if (!int.TryParse(zipTextBox.Text, out zipcode))
            {
                e.Cancel = true; // Stops focus changing process
                                 // Will NOT proceed to Validated event

                errorProvider1.SetError(zipTextBox, "Enter an integer."); // Set error message

                zipTextBox.SelectAll(); // Select all text in inputTxt to ease correction
            }
            else
            {
                if ((zipcode <= Address.MIN_ZIP) && (zipcode >= Address.MAX_ZIP))
                {
                    e.Cancel = true; // Stops focus changing process
                                     // Will NOT proceed to Validated event

                    errorProvider1.SetError(zipTextBox, "Enter a valid U.S. 5-digit zip code."); // Set error message

                    zipTextBox.SelectAll(); // Select all text in inputTxt to ease correction
                }
            }
        }

        // Precondition:  None
        // Postcondition: Default state is selected
        private void addAddressForm_Load(object sender, EventArgs e)
        {
            statesComboBox.SelectedIndex = DEFAULT_STATE_INDEX;
        }

        // Precondition:  User has initiated click on addAddressButton
        // Postcondition: All inputs are validated, if valid is dismissed with OK result sent to Program2Form
        private void addAddressButton_Click(object sender, EventArgs e)
        {
            // ValidateChildren will validate all controls on the form
            if (this.ValidateChildren())
                this.DialogResult = DialogResult.OK;
        }

        // Precondition:  User has initiated click on clearButton
        // Postcondition: All text boxes on AddAddressForm are cleared
        private void clearButton_Click(object sender, EventArgs e)
        {
            // Iterate through every Control on form
            foreach (Control guiControl in Controls)
            {
                // Determine whether Control is TextBox
                if (guiControl is TextBox)
                {
                    // Clear TextBox
                    ((TextBox)guiControl).Clear();
                }
            }
        }

        // Precondition:  User has initiated click on cancelButton
        // Postcondition: If left-click, AddAddressForm is dismissed with Cancel result
        private void cancelButton_Click(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}