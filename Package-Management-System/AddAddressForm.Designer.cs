namespace UPVApp
{
    partial class addAddressForm
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
            this.components = new System.ComponentModel.Container();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.address2TextBox = new System.Windows.Forms.TextBox();
            this.address1TextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.zipTextBox = new System.Windows.Forms.TextBox();
            this.originLbl = new System.Windows.Forms.Label();
            this.addAddressButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.statesComboBox = new System.Windows.Forms.ComboBox();
            this.clearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 41;
            this.label6.Text = "State";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 20);
            this.label5.TabIndex = 40;
            this.label5.Text = "City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Name";
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(116, 129);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(148, 26);
            this.cityTextBox.TabIndex = 3;
            this.cityTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.city_Validating);
            this.cityTextBox.Validated += new System.EventHandler(this.city_Validated);
            // 
            // address2TextBox
            // 
            this.address2TextBox.Location = new System.Drawing.Point(116, 94);
            this.address2TextBox.Name = "address2TextBox";
            this.address2TextBox.Size = new System.Drawing.Size(148, 26);
            this.address2TextBox.TabIndex = 2;
            // 
            // address1TextBox
            // 
            this.address1TextBox.Location = new System.Drawing.Point(116, 59);
            this.address1TextBox.Name = "address1TextBox";
            this.address1TextBox.Size = new System.Drawing.Size(148, 26);
            this.address1TextBox.TabIndex = 1;
            this.address1TextBox.Validating += new System.ComponentModel.CancelEventHandler(this.address1_Validating);
            this.address1TextBox.Validated += new System.EventHandler(this.address1_Validated);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(116, 23);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(148, 26);
            this.nameTextBox.TabIndex = 0;
            this.nameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.name_Validating);
            this.nameTextBox.Validated += new System.EventHandler(this.name_Validated);
            // 
            // zipTextBox
            // 
            this.zipTextBox.Location = new System.Drawing.Point(116, 201);
            this.zipTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.Size = new System.Drawing.Size(148, 26);
            this.zipTextBox.TabIndex = 5;
            this.zipTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.zip_Validating);
            this.zipTextBox.Validated += new System.EventHandler(this.zip_Validated);
            // 
            // originLbl
            // 
            this.originLbl.AutoSize = true;
            this.originLbl.Location = new System.Drawing.Point(37, 204);
            this.originLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.originLbl.Name = "originLbl";
            this.originLbl.Size = new System.Drawing.Size(73, 20);
            this.originLbl.TabIndex = 35;
            this.originLbl.Text = "Zip Code";
            // 
            // addAddressButton
            // 
            this.addAddressButton.Location = new System.Drawing.Point(14, 246);
            this.addAddressButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addAddressButton.Name = "addAddressButton";
            this.addAddressButton.Size = new System.Drawing.Size(82, 66);
            this.addAddressButton.TabIndex = 6;
            this.addAddressButton.Text = "Add Address";
            this.addAddressButton.UseVisualStyleBackColor = true;
            this.addAddressButton.Click += new System.EventHandler(this.addAddressButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(210, 246);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(84, 66);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cancelButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // statesComboBox
            // 
            this.statesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statesComboBox.FormattingEnabled = true;
            this.statesComboBox.Items.AddRange(new object[] {
            "AL",
            "AK",
            "AZ",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "FL",
            "GA",
            "HI",
            "ID",
            "IL",
            "IN",
            "IA",
            "KS",
            "KY",
            "LA",
            "ME",
            "MD",
            "MA",
            "MI",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VA",
            "WA",
            "WV",
            "WI",
            "WY"});
            this.statesComboBox.Location = new System.Drawing.Point(116, 164);
            this.statesComboBox.Name = "statesComboBox";
            this.statesComboBox.Size = new System.Drawing.Size(148, 28);
            this.statesComboBox.TabIndex = 4;
            this.statesComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.statesComboBox_Validating);
            this.statesComboBox.Validated += new System.EventHandler(this.statesComboBox_Validated);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(111, 246);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(84, 66);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // addAddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(307, 326);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.statesComboBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addAddressButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.address2TextBox);
            this.Controls.Add(this.address1TextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.zipTextBox);
            this.Controls.Add(this.originLbl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "addAddressForm";
            this.Text = "Add Address";
            this.Load += new System.EventHandler(this.addAddressForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox address2TextBox;
        private System.Windows.Forms.TextBox address1TextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox zipTextBox;
        private System.Windows.Forms.Label originLbl;
        private System.Windows.Forms.Button addAddressButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox statesComboBox;
        private System.Windows.Forms.Button clearButton;
    }
}