﻿namespace EmployeeTestApp
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
            this.buttonShowName = new System.Windows.Forms.Button();
            this.textNameDisplayField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonShowName
            // 
            this.buttonShowName.Location = new System.Drawing.Point(98, 142);
            this.buttonShowName.Name = "buttonShowName";
            this.buttonShowName.Size = new System.Drawing.Size(75, 23);
            this.buttonShowName.TabIndex = 0;
            this.buttonShowName.Text = "Show Name";
            this.buttonShowName.UseVisualStyleBackColor = true;
            this.buttonShowName.Click += new System.EventHandler(this.buttonShowName_Click);
            // 
            // textNameDisplayField
            // 
            this.textNameDisplayField.Location = new System.Drawing.Point(87, 56);
            this.textNameDisplayField.Name = "textNameDisplayField";
            this.textNameDisplayField.Size = new System.Drawing.Size(100, 20);
            this.textNameDisplayField.TabIndex = 1;
            this.textNameDisplayField.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.textNameDisplayField);
            this.Controls.Add(this.buttonShowName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonShowName;
        private System.Windows.Forms.TextBox textNameDisplayField;
    }
}
