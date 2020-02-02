namespace GuessNumber
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
            this.newNumButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // newNumButton
            // 
            this.newNumButton.Location = new System.Drawing.Point(12, 12);
            this.newNumButton.Name = "newNumButton";
            this.newNumButton.Size = new System.Drawing.Size(347, 41);
            this.newNumButton.TabIndex = 0;
            this.newNumButton.Text = "New Number!";
            this.newNumButton.UseVisualStyleBackColor = true;
            this.newNumButton.Click += new System.EventHandler(this.newNumButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(191, 211);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(168, 21);
            this.submitButton.TabIndex = 1;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(12, 212);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(173, 20);
            this.inputBox.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 59);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(347, 147);
            this.listBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(371, 248);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.newNumButton);
            this.Name = "Form1";
            this.Text = "Guess a Number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newNumButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.ListBox listBox1;
    }
}

