/*
 * C9519
 * Program2
 * 1 November 2016
 * CIS 200-01
 * Creates the main user parcel view form that allows a user to view stored
 * addresses and parcels as well as add new addresses and parcels
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
    internal partial class Program2Form : Form
    {
        UserParcelView upv = new UserParcelView();  // Creates a user parcel view

        public Program2Form()
        {
            InitializeComponent();

            // Add test data to UPV
            AddAddresses();
            AddLetters();
        }

        // Precondition:  None
        // Postcondition: Helper method to add test addresses to the upv
        private void AddAddresses()
        {
            // Add test data to upv list
            upv.AddAddress("John Smith", "123 Any St.", "Apt. 45",
                "Louisville", "KY", 40202);
            upv.AddAddress("Jane Doe", "987 Main St.", "",
                "Beverly Hills", "CA", 90210);
            upv.AddAddress("James Kirk", "654 Roddenberry Way", "Suite 321",
                "El Paso", "TX", 79901);
            upv.AddAddress("John Crichton", "678 Pau Place", "Apt. 7",
                "Portland", "ME", 04101);
            upv.AddAddress("Frank Miller", "5503 Hames Trace", "Apt 466",
                "Louisville", "KY", 40215);
            upv.AddAddress("William Hagopian", "346 S Howard St", "PO Box 12",
                "Atlanta", "GA", 30317);
            upv.AddAddress("Judy Faust", "3983 Explorer Rd", "",
                "Wheatfield", "IN", 46392);
            upv.AddAddress("Desirae Thompson", "2009 Joe Lane", "",
                "Kearney", "MO", 64048);
        }

        // Precondition:  None
        // Postcondition: Helper method to add test parcels to the upv
        private void AddLetters()
        {
            // Add test data to upv list
            upv.AddGroundPackage(upv.AddressAt(0), upv.AddressAt(7), 12, 4, 6, 2);
            upv.AddNextDayAirPackage(upv.AddressAt(1), upv.AddressAt(6), 25, 5, 5, 15, 35.00m);
            upv.AddLetter(upv.AddressAt(2), upv.AddressAt(5), 1.25m);
            upv.AddLetter(upv.AddressAt(3), upv.AddressAt(4), 1.25m);
        }

        // Precondition:  About menu item selected
        // Postcondition: Postcondition: AddLetterForm is opened
        private void fileAboutMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            DialogResult result;            // Holds result from dialog box
            result = about.ShowDialog();    // Shows dialog box

            //MessageBox.Show("Program 2\r\nBy: C9519\r\nCIS 200-01\r\nFall 2016\r\nDue: 1 November 2016",
            //    "About Program 2");
        }

        // Precondition:  Exit item selected
        // Postcondition: Exits app
        private void fileExitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Precondition:  Insert address menu item selected
        // Postcondition: 
        private void insertAddressMenuItem_Click(object sender, EventArgs e)
        {
            // 
            addAddressForm addAddress = new addAddressForm();
            DialogResult result;                // Holds result from dialog box
            result = addAddress.ShowDialog();   // Shows dialog box

            if (result == DialogResult.OK)
            {
                upv.AddAddress(addAddress.AddName, addAddress.AddAddress1, addAddress.AddAddress2,
                    addAddress.AddCity, addAddress.AddState, addAddress.AddZip);
            }
        }

        // Precondition:  Insert letter menu item selected
        // Postcondition: AddLetterForm is opened
        private void insertLetterMenuItem_Click(object sender, EventArgs e)
        {
            List<Parcel> listOfletters = new List<Parcel>();    // List of parcels
            listOfletters = upv.ParcelList;

            AddLetterForm addLetterForm = new AddLetterForm(upv.AddressList);   // List of letters
            DialogResult result;                    // Holds result from dialog box
            result = addLetterForm.ShowDialog();    // Shows dialog box

            if (result == DialogResult.OK)
            {
                upv.AddLetter(upv.AddressAt(addLetterForm.AddOriginAddress),
                    upv.AddressAt(addLetterForm.AddDestinationAddress),
                    addLetterForm.AddFixedCost);
            }
        }

        // Precondition:  List addresses menu item selected
        // Postcondition: List of addresses is displayed
        private void reportAddressListMenuItem_Click(object sender, EventArgs e)
        {
            //Makes sure text box is cleared before viewing new additions
            displayTextbox.Clear();

            // Holds results of LINQ
            var displayAddressList =
                from address in upv.AddressList
                select address;

            // Outputs addresses to form's textbox
            StringBuilder addresSB = new StringBuilder(); // Will hold result as being built

            if (displayAddressList.Any())
            {
                foreach (var i in displayAddressList)
                {
                    addresSB.Append(i.ToString());
                    addresSB.Append($"{Environment.NewLine}");
                    addresSB.Append($"=========================");
                    addresSB.Append($"{Environment.NewLine}");
                }
            }
            displayTextbox.Text = addresSB.ToString();
        }

        // Precondition:  List parcels menu item selected
        // Postcondition: List of parcels is displayed
        private void reportParcelListMenuItem_Click(object sender, EventArgs e)
        {
            decimal runningTotal = 0;   // Holds running total of shipping costs
            // Holds results of LINQ
            var displayLetterList =
                from letter in upv.ParcelList
                select letter;

            // Outputs addresses to form's textbox
            StringBuilder parcelSB = new StringBuilder();   // Will hold result as being built
            displayTextbox.Clear();

            if (displayLetterList.Any())
            {
                foreach (var i in displayLetterList)
                {
                    parcelSB.Append(i.ToString());
                    parcelSB.Append($"{Environment.NewLine}");
                    parcelSB.Append($"=========================");
                    parcelSB.Append($"{Environment.NewLine}");
                    runningTotal += i.CalcCost();
                }
            }
            displayTextbox.Text = parcelSB.ToString();
            displayTextbox.Text += Environment.NewLine + "Running Total: " + runningTotal.ToString("C");
        }
    }
}