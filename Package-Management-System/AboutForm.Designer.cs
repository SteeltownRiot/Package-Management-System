namespace UPVApp
{
    partial class AboutForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.byLabel = new System.Windows.Forms.Label();
            this.courseLabel = new System.Windows.Forms.Label();
            this.semesterLabel = new System.Windows.Forms.Label();
            this.dueDateLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(31, 26);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(38, 20);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title";
            // 
            // byLabel
            // 
            this.byLabel.AutoSize = true;
            this.byLabel.Location = new System.Drawing.Point(31, 61);
            this.byLabel.Name = "byLabel";
            this.byLabel.Size = new System.Drawing.Size(27, 20);
            this.byLabel.TabIndex = 1;
            this.byLabel.Text = "By";
            // 
            // courseLabel
            // 
            this.courseLabel.AutoSize = true;
            this.courseLabel.Location = new System.Drawing.Point(31, 96);
            this.courseLabel.Name = "courseLabel";
            this.courseLabel.Size = new System.Drawing.Size(60, 20);
            this.courseLabel.TabIndex = 2;
            this.courseLabel.Text = "Course";
            // 
            // semesterLabel
            // 
            this.semesterLabel.AutoSize = true;
            this.semesterLabel.Location = new System.Drawing.Point(31, 131);
            this.semesterLabel.Name = "semesterLabel";
            this.semesterLabel.Size = new System.Drawing.Size(78, 20);
            this.semesterLabel.TabIndex = 3;
            this.semesterLabel.Text = "Semester";
            // 
            // dueDateLabel
            // 
            this.dueDateLabel.AutoSize = true;
            this.dueDateLabel.Location = new System.Drawing.Point(31, 166);
            this.dueDateLabel.Name = "dueDateLabel";
            this.dueDateLabel.Size = new System.Drawing.Size(78, 20);
            this.dueDateLabel.TabIndex = 4;
            this.dueDateLabel.Text = "Due Date";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(102, 210);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 46);
            this.okButton.TabIndex = 5;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // AboutForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 268);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.dueDateLabel);
            this.Controls.Add(this.semesterLabel);
            this.Controls.Add(this.courseLabel);
            this.Controls.Add(this.byLabel);
            this.Controls.Add(this.titleLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.Text = "About Program 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label byLabel;
        private System.Windows.Forms.Label courseLabel;
        private System.Windows.Forms.Label semesterLabel;
        private System.Windows.Forms.Label dueDateLabel;
        private System.Windows.Forms.Button okButton;
    }
}