namespace Test
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
            this.smnRadio = new System.Windows.Forms.RadioButton();
            this.ninRadio = new System.Windows.Forms.RadioButton();
            this.drgRadio = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.levelInput = new System.Windows.Forms.TextBox();
            this.outputTextBox = new System.Windows.Forms.Label();
            this.goButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // smnRadio
            // 
            this.smnRadio.AutoSize = true;
            this.smnRadio.Location = new System.Drawing.Point(57, 37);
            this.smnRadio.Name = "smnRadio";
            this.smnRadio.Size = new System.Drawing.Size(75, 17);
            this.smnRadio.TabIndex = 0;
            this.smnRadio.TabStop = true;
            this.smnRadio.Text = "Summoner";
            this.smnRadio.UseVisualStyleBackColor = true;
            // 
            // ninRadio
            // 
            this.ninRadio.AutoSize = true;
            this.ninRadio.Location = new System.Drawing.Point(57, 60);
            this.ninRadio.Name = "ninRadio";
            this.ninRadio.Size = new System.Drawing.Size(49, 17);
            this.ninRadio.TabIndex = 1;
            this.ninRadio.TabStop = true;
            this.ninRadio.Text = "Ninja";
            this.ninRadio.UseVisualStyleBackColor = true;
            // 
            // drgRadio
            // 
            this.drgRadio.AutoSize = true;
            this.drgRadio.Location = new System.Drawing.Point(57, 83);
            this.drgRadio.Name = "drgRadio";
            this.drgRadio.Size = new System.Drawing.Size(66, 17);
            this.drgRadio.TabIndex = 2;
            this.drgRadio.TabStop = true;
            this.drgRadio.Text = "Dragoon";
            this.drgRadio.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Level:";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(185, 37);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(100, 20);
            this.nameInput.TabIndex = 5;
            // 
            // levelInput
            // 
            this.levelInput.Location = new System.Drawing.Point(185, 87);
            this.levelInput.Name = "levelInput";
            this.levelInput.Size = new System.Drawing.Size(100, 20);
            this.levelInput.TabIndex = 6;
            // 
            // outputTextBox
            // 
            this.outputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputTextBox.Location = new System.Drawing.Point(44, 119);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(241, 66);
            this.outputTextBox.TabIndex = 7;
            this.outputTextBox.Text = " ";
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(45, 197);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(160, 39);
            this.goButton.TabIndex = 8;
            this.goButton.Text = "Go!";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(211, 197);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 39);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 248);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.levelInput);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.drgRadio);
            this.Controls.Add(this.ninRadio);
            this.Controls.Add(this.smnRadio);
            this.Name = "Form1";
            this.Text = "Job App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton smnRadio;
        private System.Windows.Forms.RadioButton ninRadio;
        private System.Windows.Forms.RadioButton drgRadio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.TextBox levelInput;
        private System.Windows.Forms.Label outputTextBox;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.Button exitButton;
    }
}

