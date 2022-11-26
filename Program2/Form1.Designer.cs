namespace Program2
{
    partial class Form1
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
            this.submitButton = new System.Windows.Forms.Button();
            this.firstCharLabel = new System.Windows.Forms.Label();
            this.firstCharTextBox = new System.Windows.Forms.TextBox();
            this.creditHoursTextBox = new System.Windows.Forms.TextBox();
            this.creditHoursLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.resultHeaderLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(130, 58);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(100, 23);
            this.submitButton.TabIndex = 3;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // firstCharLabel
            // 
            this.firstCharLabel.AutoSize = true;
            this.firstCharLabel.Location = new System.Drawing.Point(9, 9);
            this.firstCharLabel.Name = "firstCharLabel";
            this.firstCharLabel.Size = new System.Drawing.Size(115, 13);
            this.firstCharLabel.TabIndex = 1;
            this.firstCharLabel.Text = "First letter of last name:";
            // 
            // firstCharTextBox
            // 
            this.firstCharTextBox.Location = new System.Drawing.Point(130, 6);
            this.firstCharTextBox.MaxLength = 1;
            this.firstCharTextBox.Name = "firstCharTextBox";
            this.firstCharTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstCharTextBox.TabIndex = 0;
            // 
            // creditHoursTextBox
            // 
            this.creditHoursTextBox.Location = new System.Drawing.Point(130, 32);
            this.creditHoursTextBox.Name = "creditHoursTextBox";
            this.creditHoursTextBox.Size = new System.Drawing.Size(100, 20);
            this.creditHoursTextBox.TabIndex = 1;
            // 
            // creditHoursLabel
            // 
            this.creditHoursLabel.AutoSize = true;
            this.creditHoursLabel.Location = new System.Drawing.Point(32, 35);
            this.creditHoursLabel.Name = "creditHoursLabel";
            this.creditHoursLabel.Size = new System.Drawing.Size(92, 13);
            this.creditHoursLabel.TabIndex = 3;
            this.creditHoursLabel.Text = "Total credit hours:";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoEllipsis = true;
            this.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(12, 122);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(218, 30);
            this.resultLabel.TabIndex = 5;
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resultHeaderLabel
            // 
            this.resultHeaderLabel.AutoSize = true;
            this.resultHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultHeaderLabel.Location = new System.Drawing.Point(56, 106);
            this.resultHeaderLabel.Name = "resultHeaderLabel";
            this.resultHeaderLabel.Size = new System.Drawing.Size(130, 13);
            this.resultHeaderLabel.TabIndex = 6;
            this.resultHeaderLabel.Text = "First opportunity to register";
            // 
            // clearButton
            // 
            this.clearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clearButton.Location = new System.Drawing.Point(24, 58);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(100, 23);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.submitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.clearButton;
            this.ClientSize = new System.Drawing.Size(242, 166);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.resultHeaderLabel);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.creditHoursTextBox);
            this.Controls.Add(this.creditHoursLabel);
            this.Controls.Add(this.firstCharTextBox);
            this.Controls.Add(this.firstCharLabel);
            this.Controls.Add(this.submitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Program 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label firstCharLabel;
        private System.Windows.Forms.TextBox firstCharTextBox;
        private System.Windows.Forms.TextBox creditHoursTextBox;
        private System.Windows.Forms.Label creditHoursLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label resultHeaderLabel;
        private System.Windows.Forms.Button clearButton;
    }
}

