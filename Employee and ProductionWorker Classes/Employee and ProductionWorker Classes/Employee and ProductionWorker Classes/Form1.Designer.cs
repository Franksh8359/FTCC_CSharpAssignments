namespace Employee_and_ProductionWorker_Classes
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
            this.inputGroupBox = new System.Windows.Forms.GroupBox();
            this.payIn = new System.Windows.Forms.TextBox();
            this.numIn = new System.Windows.Forms.TextBox();
            this.nameIn = new System.Windows.Forms.TextBox();
            this.payLabel = new System.Windows.Forms.Label();
            this.shiftLabel = new System.Windows.Forms.Label();
            this.numLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.outputGroupBox = new System.Windows.Forms.GroupBox();
            this.payOut = new System.Windows.Forms.Label();
            this.shiftOut = new System.Windows.Forms.Label();
            this.numOut = new System.Windows.Forms.Label();
            this.nameOut = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.shiftIn = new System.Windows.Forms.ComboBox();
            this.inputGroupBox.SuspendLayout();
            this.outputGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputGroupBox
            // 
            this.inputGroupBox.Controls.Add(this.shiftIn);
            this.inputGroupBox.Controls.Add(this.payIn);
            this.inputGroupBox.Controls.Add(this.numIn);
            this.inputGroupBox.Controls.Add(this.nameIn);
            this.inputGroupBox.Controls.Add(this.payLabel);
            this.inputGroupBox.Controls.Add(this.shiftLabel);
            this.inputGroupBox.Controls.Add(this.numLabel);
            this.inputGroupBox.Controls.Add(this.nameLabel);
            this.inputGroupBox.Location = new System.Drawing.Point(12, 12);
            this.inputGroupBox.Name = "inputGroupBox";
            this.inputGroupBox.Size = new System.Drawing.Size(212, 153);
            this.inputGroupBox.TabIndex = 0;
            this.inputGroupBox.TabStop = false;
            this.inputGroupBox.Text = "Enter Employee Data:";
            // 
            // payIn
            // 
            this.payIn.Location = new System.Drawing.Point(91, 107);
            this.payIn.Name = "payIn";
            this.payIn.Size = new System.Drawing.Size(100, 20);
            this.payIn.TabIndex = 6;
            // 
            // numIn
            // 
            this.numIn.Location = new System.Drawing.Point(91, 54);
            this.numIn.Name = "numIn";
            this.numIn.Size = new System.Drawing.Size(100, 20);
            this.numIn.TabIndex = 5;
            // 
            // nameIn
            // 
            this.nameIn.Location = new System.Drawing.Point(91, 29);
            this.nameIn.Name = "nameIn";
            this.nameIn.Size = new System.Drawing.Size(100, 20);
            this.nameIn.TabIndex = 4;
            // 
            // payLabel
            // 
            this.payLabel.AutoSize = true;
            this.payLabel.Location = new System.Drawing.Point(13, 110);
            this.payLabel.Name = "payLabel";
            this.payLabel.Size = new System.Drawing.Size(72, 13);
            this.payLabel.TabIndex = 3;
            this.payLabel.Text = "Hourly Wage:";
            // 
            // shiftLabel
            // 
            this.shiftLabel.AutoSize = true;
            this.shiftLabel.Location = new System.Drawing.Point(54, 83);
            this.shiftLabel.Name = "shiftLabel";
            this.shiftLabel.Size = new System.Drawing.Size(31, 13);
            this.shiftLabel.TabIndex = 2;
            this.shiftLabel.Text = "Shift:";
            // 
            // numLabel
            // 
            this.numLabel.AutoSize = true;
            this.numLabel.Location = new System.Drawing.Point(38, 57);
            this.numLabel.Name = "numLabel";
            this.numLabel.Size = new System.Drawing.Size(47, 13);
            this.numLabel.TabIndex = 1;
            this.numLabel.Text = "Number:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(47, 32);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            // 
            // outputGroupBox
            // 
            this.outputGroupBox.Controls.Add(this.payOut);
            this.outputGroupBox.Controls.Add(this.shiftOut);
            this.outputGroupBox.Controls.Add(this.numOut);
            this.outputGroupBox.Controls.Add(this.nameOut);
            this.outputGroupBox.Controls.Add(this.label1);
            this.outputGroupBox.Controls.Add(this.label2);
            this.outputGroupBox.Controls.Add(this.label3);
            this.outputGroupBox.Controls.Add(this.label4);
            this.outputGroupBox.Location = new System.Drawing.Point(230, 12);
            this.outputGroupBox.Name = "outputGroupBox";
            this.outputGroupBox.Size = new System.Drawing.Size(212, 153);
            this.outputGroupBox.TabIndex = 8;
            this.outputGroupBox.TabStop = false;
            this.outputGroupBox.Text = "Latest Employee Record:";
            // 
            // payOut
            // 
            this.payOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.payOut.Location = new System.Drawing.Point(91, 108);
            this.payOut.Name = "payOut";
            this.payOut.Size = new System.Drawing.Size(97, 23);
            this.payOut.TabIndex = 7;
            this.payOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shiftOut
            // 
            this.shiftOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.shiftOut.Location = new System.Drawing.Point(91, 81);
            this.shiftOut.Name = "shiftOut";
            this.shiftOut.Size = new System.Drawing.Size(97, 23);
            this.shiftOut.TabIndex = 6;
            this.shiftOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numOut
            // 
            this.numOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numOut.Location = new System.Drawing.Point(91, 54);
            this.numOut.Name = "numOut";
            this.numOut.Size = new System.Drawing.Size(97, 23);
            this.numOut.TabIndex = 5;
            this.numOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameOut
            // 
            this.nameOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameOut.Location = new System.Drawing.Point(91, 27);
            this.nameOut.Name = "nameOut";
            this.nameOut.Size = new System.Drawing.Size(97, 23);
            this.nameOut.TabIndex = 4;
            this.nameOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hourly Wage:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Shift:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Name:";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(13, 172);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(211, 33);
            this.submitButton.TabIndex = 9;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(230, 171);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(102, 34);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(338, 171);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(102, 34);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // shiftIn
            // 
            this.shiftIn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.shiftIn.FormattingEnabled = true;
            this.shiftIn.Items.AddRange(new object[] {
            "1",
            "2"});
            this.shiftIn.Location = new System.Drawing.Point(91, 81);
            this.shiftIn.Name = "shiftIn";
            this.shiftIn.Size = new System.Drawing.Size(100, 21);
            this.shiftIn.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 217);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.outputGroupBox);
            this.Controls.Add(this.inputGroupBox);
            this.Name = "Form1";
            this.Text = "Employee and Production Worker";
            this.inputGroupBox.ResumeLayout(false);
            this.inputGroupBox.PerformLayout();
            this.outputGroupBox.ResumeLayout(false);
            this.outputGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox inputGroupBox;
        private System.Windows.Forms.Label numLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label payLabel;
        private System.Windows.Forms.Label shiftLabel;
        private System.Windows.Forms.TextBox payIn;
        private System.Windows.Forms.TextBox numIn;
        private System.Windows.Forms.TextBox nameIn;
        private System.Windows.Forms.GroupBox outputGroupBox;
        private System.Windows.Forms.Label payOut;
        private System.Windows.Forms.Label shiftOut;
        private System.Windows.Forms.Label numOut;
        private System.Windows.Forms.Label nameOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ComboBox shiftIn;
    }
}

