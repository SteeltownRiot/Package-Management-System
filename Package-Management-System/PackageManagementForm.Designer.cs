namespace UPVApp
{
    partial class Program2Form
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileAboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertAddressMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertLetterMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportListAddressMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportListParcelsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayTextbox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.insertToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(409, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileAboutMenuItem,
            this.fileExitMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // fileAboutMenuItem
            // 
            this.fileAboutMenuItem.Name = "fileAboutMenuItem";
            this.fileAboutMenuItem.Size = new System.Drawing.Size(107, 22);
            this.fileAboutMenuItem.Text = "&About";
            this.fileAboutMenuItem.Click += new System.EventHandler(this.fileAboutMenuItem_Click);
            // 
            // fileExitMenuItem
            // 
            this.fileExitMenuItem.Name = "fileExitMenuItem";
            this.fileExitMenuItem.Size = new System.Drawing.Size(107, 22);
            this.fileExitMenuItem.Text = "E&xit";
            this.fileExitMenuItem.Click += new System.EventHandler(this.fileExitMenuItem_Click);
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertAddressMenuItem,
            this.insertLetterMenuItem});
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.Size = new System.Drawing.Size(48, 22);
            this.insertToolStripMenuItem.Text = "&Insert";
            // 
            // insertAddressMenuItem
            // 
            this.insertAddressMenuItem.Name = "insertAddressMenuItem";
            this.insertAddressMenuItem.Size = new System.Drawing.Size(116, 22);
            this.insertAddressMenuItem.Text = "&Address";
            this.insertAddressMenuItem.Click += new System.EventHandler(this.insertAddressMenuItem_Click);
            // 
            // insertLetterMenuItem
            // 
            this.insertLetterMenuItem.Name = "insertLetterMenuItem";
            this.insertLetterMenuItem.Size = new System.Drawing.Size(116, 22);
            this.insertLetterMenuItem.Text = "&Letter";
            this.insertLetterMenuItem.Click += new System.EventHandler(this.insertLetterMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportListAddressMenuItem,
            this.reportListParcelsMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(54, 22);
            this.reportToolStripMenuItem.Text = "&Report";
            // 
            // reportListAddressMenuItem
            // 
            this.reportListAddressMenuItem.Name = "reportListAddressMenuItem";
            this.reportListAddressMenuItem.Size = new System.Drawing.Size(148, 22);
            this.reportListAddressMenuItem.Text = "List &Addresses";
            this.reportListAddressMenuItem.Click += new System.EventHandler(this.reportAddressListMenuItem_Click);
            // 
            // reportListParcelsMenuItem
            // 
            this.reportListParcelsMenuItem.Name = "reportListParcelsMenuItem";
            this.reportListParcelsMenuItem.Size = new System.Drawing.Size(148, 22);
            this.reportListParcelsMenuItem.Text = "List &Parcels";
            this.reportListParcelsMenuItem.Click += new System.EventHandler(this.reportParcelListMenuItem_Click);
            // 
            // displayTextbox
            // 
            this.displayTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displayTextbox.Location = new System.Drawing.Point(8, 23);
            this.displayTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.displayTextbox.Multiline = true;
            this.displayTextbox.Name = "displayTextbox";
            this.displayTextbox.ReadOnly = true;
            this.displayTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.displayTextbox.Size = new System.Drawing.Size(395, 293);
            this.displayTextbox.TabIndex = 1;
            // 
            // Program2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 323);
            this.Controls.Add(this.displayTextbox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Program2Form";
            this.Text = "Package Manager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.TextBox displayTextbox;
        private System.Windows.Forms.ToolStripMenuItem fileAboutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileExitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportListAddressMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportListParcelsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertAddressMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertLetterMenuItem;
    }
}

