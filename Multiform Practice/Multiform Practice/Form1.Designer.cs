namespace Multiform_Practice
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
            this.dusplayFormButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dusplayFormButton
            // 
            this.dusplayFormButton.Location = new System.Drawing.Point(41, 33);
            this.dusplayFormButton.Name = "dusplayFormButton";
            this.dusplayFormButton.Size = new System.Drawing.Size(75, 23);
            this.dusplayFormButton.TabIndex = 0;
            this.dusplayFormButton.Text = "Display Form";
            this.dusplayFormButton.UseVisualStyleBackColor = true;
            this.dusplayFormButton.Click += new System.EventHandler(this.dusplayFormButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(122, 33);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 85);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.dusplayFormButton);
            this.Name = "Form1";
            this.Text = "Multiform Practice";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dusplayFormButton;
        private System.Windows.Forms.Button exitButton;
    }
}

