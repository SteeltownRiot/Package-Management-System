namespace UPVApp
{
    partial class AddLetterForm
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
            this.weightLbl = new System.Windows.Forms.Label();
            this.lengthLbl = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addLetterButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fixedCostTextBox = new System.Windows.Forms.TextBox();
            this.oAddressComboBox = new System.Windows.Forms.ComboBox();
            this.dAddressComboBox = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // weightLbl
            // 
            this.weightLbl.AutoSize = true;
            this.weightLbl.Location = new System.Drawing.Point(18, 147);
            this.weightLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.weightLbl.Name = "weightLbl";
            this.weightLbl.Size = new System.Drawing.Size(85, 20);
            this.weightLbl.TabIndex = 32;
            this.weightLbl.Text = "Enter Cost";
            // 
            // lengthLbl
            // 
            this.lengthLbl.AutoSize = true;
            this.lengthLbl.Location = new System.Drawing.Point(16, 19);
            this.lengthLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lengthLbl.Name = "lengthLbl";
            this.lengthLbl.Size = new System.Drawing.Size(181, 20);
            this.lengthLbl.TabIndex = 29;
            this.lengthLbl.Text = "Pick Orginiation Address";
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(132, 198);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(102, 48);
            this.cancelButton.TabIndex = 45;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cancelButton_MouseDown);
            // 
            // addLetterButton
            // 
            this.addLetterButton.Location = new System.Drawing.Point(22, 198);
            this.addLetterButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addLetterButton.Name = "addLetterButton";
            this.addLetterButton.Size = new System.Drawing.Size(102, 48);
            this.addLetterButton.TabIndex = 44;
            this.addLetterButton.Text = "Add Letter";
            this.addLetterButton.UseVisualStyleBackColor = true;
            this.addLetterButton.Click += new System.EventHandler(this.addLetterButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 20);
            this.label1.TabIndex = 46;
            this.label1.Text = "Pick Destiniation Address";
            // 
            // fixedCostTextBox
            // 
            this.fixedCostTextBox.Location = new System.Drawing.Point(117, 144);
            this.fixedCostTextBox.Name = "fixedCostTextBox";
            this.fixedCostTextBox.Size = new System.Drawing.Size(115, 26);
            this.fixedCostTextBox.TabIndex = 47;
            this.fixedCostTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.fixedCostTextBox_Validating);
            this.fixedCostTextBox.Validated += new System.EventHandler(this.fixedCostTextBox_Validated);
            // 
            // oAddressComboBox
            // 
            this.oAddressComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.oAddressComboBox.FormattingEnabled = true;
            this.oAddressComboBox.Location = new System.Drawing.Point(20, 43);
            this.oAddressComboBox.Name = "oAddressComboBox";
            this.oAddressComboBox.Size = new System.Drawing.Size(212, 28);
            this.oAddressComboBox.TabIndex = 48;
            this.oAddressComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.oAddressComboBox_Validating);
            this.oAddressComboBox.Validated += new System.EventHandler(this.oAddressComboBox_Validated);
            // 
            // dAddressComboBox
            // 
            this.dAddressComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dAddressComboBox.FormattingEnabled = true;
            this.dAddressComboBox.Location = new System.Drawing.Point(22, 106);
            this.dAddressComboBox.Name = "dAddressComboBox";
            this.dAddressComboBox.Size = new System.Drawing.Size(210, 28);
            this.dAddressComboBox.TabIndex = 49;
            this.dAddressComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.dAddressComboBox_Validating);
            this.dAddressComboBox.Validated += new System.EventHandler(this.dAddressComboBox_Validated);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddLetterForm
            // 
            this.AcceptButton = this.addLetterButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(250, 260);
            this.Controls.Add(this.dAddressComboBox);
            this.Controls.Add(this.oAddressComboBox);
            this.Controls.Add(this.fixedCostTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addLetterButton);
            this.Controls.Add(this.weightLbl);
            this.Controls.Add(this.lengthLbl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddLetterForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Add Letter";
            this.Load += new System.EventHandler(this.AddLetterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label weightLbl;
        private System.Windows.Forms.Label lengthLbl;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button addLetterButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fixedCostTextBox;
        private System.Windows.Forms.ComboBox oAddressComboBox;
        private System.Windows.Forms.ComboBox dAddressComboBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}