namespace PapildomaUzduotis2
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
            this.startingDateLabel = new System.Windows.Forms.Label();
            this.loanLabel = new System.Windows.Forms.Label();
            this.interestRateLabel = new System.Windows.Forms.Label();
            this.paymentCountLabel = new System.Windows.Forms.Label();
            this.loanTextBox = new System.Windows.Forms.TextBox();
            this.interestRateTextBox = new System.Windows.Forms.TextBox();
            this.paymentsCountTextBox = new System.Windows.Forms.TextBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.startingDateTextBox = new System.Windows.Forms.TextBox();
            this.dateFormatLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startingDateLabel
            // 
            this.startingDateLabel.AutoSize = true;
            this.startingDateLabel.Location = new System.Drawing.Point(12, 9);
            this.startingDateLabel.Name = "startingDateLabel";
            this.startingDateLabel.Size = new System.Drawing.Size(72, 13);
            this.startingDateLabel.TabIndex = 0;
            this.startingDateLabel.Text = "Starting Date:";
            // 
            // loanLabel
            // 
            this.loanLabel.AutoSize = true;
            this.loanLabel.Location = new System.Drawing.Point(12, 35);
            this.loanLabel.Name = "loanLabel";
            this.loanLabel.Size = new System.Drawing.Size(34, 13);
            this.loanLabel.TabIndex = 1;
            this.loanLabel.Text = "Loan:";
            // 
            // interestRateLabel
            // 
            this.interestRateLabel.AutoSize = true;
            this.interestRateLabel.Location = new System.Drawing.Point(12, 61);
            this.interestRateLabel.Name = "interestRateLabel";
            this.interestRateLabel.Size = new System.Drawing.Size(68, 13);
            this.interestRateLabel.TabIndex = 2;
            this.interestRateLabel.Text = "Interest Rate";
            // 
            // paymentCountLabel
            // 
            this.paymentCountLabel.AutoSize = true;
            this.paymentCountLabel.Location = new System.Drawing.Point(12, 87);
            this.paymentCountLabel.Name = "paymentCountLabel";
            this.paymentCountLabel.Size = new System.Drawing.Size(87, 13);
            this.paymentCountLabel.TabIndex = 3;
            this.paymentCountLabel.Text = "Payments Count:";
            // 
            // loanTextBox
            // 
            this.loanTextBox.Location = new System.Drawing.Point(110, 35);
            this.loanTextBox.Name = "loanTextBox";
            this.loanTextBox.Size = new System.Drawing.Size(100, 20);
            this.loanTextBox.TabIndex = 5;
            this.loanTextBox.TextChanged += new System.EventHandler(this.loanTextBox_TextChanged);
            // 
            // interestRateTextBox
            // 
            this.interestRateTextBox.Location = new System.Drawing.Point(110, 61);
            this.interestRateTextBox.Name = "interestRateTextBox";
            this.interestRateTextBox.Size = new System.Drawing.Size(100, 20);
            this.interestRateTextBox.TabIndex = 6;
            this.interestRateTextBox.TextChanged += new System.EventHandler(this.interestRateTextBox_TextChanged);
            // 
            // paymentsCountTextBox
            // 
            this.paymentsCountTextBox.Location = new System.Drawing.Point(110, 87);
            this.paymentsCountTextBox.Name = "paymentsCountTextBox";
            this.paymentsCountTextBox.Size = new System.Drawing.Size(100, 20);
            this.paymentsCountTextBox.TabIndex = 7;
            this.paymentsCountTextBox.TextChanged += new System.EventHandler(this.paymentsCountTextBox_TextChanged);
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(110, 113);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(75, 23);
            this.generateButton.TabIndex = 8;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // startingDateTextBox
            // 
            this.startingDateTextBox.Location = new System.Drawing.Point(110, 9);
            this.startingDateTextBox.Name = "startingDateTextBox";
            this.startingDateTextBox.Size = new System.Drawing.Size(100, 20);
            this.startingDateTextBox.TabIndex = 4;
            // 
            // dateFormatLabel
            // 
            this.dateFormatLabel.AutoSize = true;
            this.dateFormatLabel.Location = new System.Drawing.Point(216, 9);
            this.dateFormatLabel.Name = "dateFormatLabel";
            this.dateFormatLabel.Size = new System.Drawing.Size(117, 13);
            this.dateFormatLabel.TabIndex = 9;
            this.dateFormatLabel.Text = "Format: YYYY/MM/DD";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(191, 118);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(115, 13);
            this.resultLabel.TabIndex = 10;
            this.resultLabel.Text = "Type in the parameters";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 149);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.dateFormatLabel);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.paymentsCountTextBox);
            this.Controls.Add(this.interestRateTextBox);
            this.Controls.Add(this.loanTextBox);
            this.Controls.Add(this.startingDateTextBox);
            this.Controls.Add(this.paymentCountLabel);
            this.Controls.Add(this.interestRateLabel);
            this.Controls.Add(this.loanLabel);
            this.Controls.Add(this.startingDateLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label startingDateLabel;
        private System.Windows.Forms.Label loanLabel;
        private System.Windows.Forms.Label interestRateLabel;
        private System.Windows.Forms.Label paymentCountLabel;
        private System.Windows.Forms.TextBox loanTextBox;
        private System.Windows.Forms.TextBox interestRateTextBox;
        private System.Windows.Forms.TextBox paymentsCountTextBox;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.TextBox startingDateTextBox;
        private System.Windows.Forms.Label dateFormatLabel;
        private System.Windows.Forms.Label resultLabel;
    }
}

