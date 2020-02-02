namespace Word_Counter
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
            this.outputGroupBox = new System.Windows.Forms.GroupBox();
            this.averageOutputLabel = new System.Windows.Forms.Label();
            this.wordsOutputLabel = new System.Windows.Forms.Label();
            this.averageLabel = new System.Windows.Forms.Label();
            this.wordsLabel = new System.Windows.Forms.Label();
            this.inputGroupBox = new System.Windows.Forms.GroupBox();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.outputGroupBox.SuspendLayout();
            this.inputGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // outputGroupBox
            // 
            this.outputGroupBox.Controls.Add(this.averageOutputLabel);
            this.outputGroupBox.Controls.Add(this.wordsOutputLabel);
            this.outputGroupBox.Controls.Add(this.averageLabel);
            this.outputGroupBox.Controls.Add(this.wordsLabel);
            this.outputGroupBox.Location = new System.Drawing.Point(12, 78);
            this.outputGroupBox.Name = "outputGroupBox";
            this.outputGroupBox.Size = new System.Drawing.Size(318, 101);
            this.outputGroupBox.TabIndex = 0;
            this.outputGroupBox.TabStop = false;
            this.outputGroupBox.Text = "String Statistics";
            // 
            // averageOutputLabel
            // 
            this.averageOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.averageOutputLabel.Location = new System.Drawing.Point(184, 58);
            this.averageOutputLabel.Name = "averageOutputLabel";
            this.averageOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.averageOutputLabel.TabIndex = 3;
            this.averageOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wordsOutputLabel
            // 
            this.wordsOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wordsOutputLabel.Location = new System.Drawing.Point(184, 26);
            this.wordsOutputLabel.Name = "wordsOutputLabel";
            this.wordsOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.wordsOutputLabel.TabIndex = 2;
            this.wordsOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // averageLabel
            // 
            this.averageLabel.AutoSize = true;
            this.averageLabel.Location = new System.Drawing.Point(27, 63);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(151, 13);
            this.averageLabel.TabIndex = 1;
            this.averageLabel.Text = "Average Characters per Word:";
            // 
            // wordsLabel
            // 
            this.wordsLabel.AutoSize = true;
            this.wordsLabel.Location = new System.Drawing.Point(85, 32);
            this.wordsLabel.Name = "wordsLabel";
            this.wordsLabel.Size = new System.Drawing.Size(93, 13);
            this.wordsLabel.TabIndex = 0;
            this.wordsLabel.Text = "Number of Words:";
            // 
            // inputGroupBox
            // 
            this.inputGroupBox.Controls.Add(this.inputTextBox);
            this.inputGroupBox.Location = new System.Drawing.Point(12, 12);
            this.inputGroupBox.Name = "inputGroupBox";
            this.inputGroupBox.Size = new System.Drawing.Size(318, 56);
            this.inputGroupBox.TabIndex = 1;
            this.inputGroupBox.TabStop = false;
            this.inputGroupBox.Text = "Enter a string of text...";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(6, 19);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(306, 20);
            this.inputTextBox.TabIndex = 0;
            // 
            // calculateButton
            // 
            this.calculateButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.calculateButton.Location = new System.Drawing.Point(12, 185);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(156, 33);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "Calculate Stats";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(174, 185);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 33);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(255, 185);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 33);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 233);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.inputGroupBox);
            this.Controls.Add(this.outputGroupBox);
            this.Name = "Form1";
            this.Text = "Word Counter";
            this.outputGroupBox.ResumeLayout(false);
            this.outputGroupBox.PerformLayout();
            this.inputGroupBox.ResumeLayout(false);
            this.inputGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox outputGroupBox;
        private System.Windows.Forms.Label averageOutputLabel;
        private System.Windows.Forms.Label wordsOutputLabel;
        private System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.Label wordsLabel;
        private System.Windows.Forms.GroupBox inputGroupBox;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

