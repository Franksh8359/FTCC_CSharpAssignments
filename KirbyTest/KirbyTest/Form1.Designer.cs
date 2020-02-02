namespace KirbyTest
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
            this.warriorButton = new System.Windows.Forms.Button();
            this.archerButton = new System.Windows.Forms.Button();
            this.mageButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.weaponOutput = new System.Windows.Forms.Label();
            this.elementOutput = new System.Windows.Forms.Label();
            this.levelOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // warriorButton
            // 
            this.warriorButton.Location = new System.Drawing.Point(37, 41);
            this.warriorButton.Name = "warriorButton";
            this.warriorButton.Size = new System.Drawing.Size(180, 38);
            this.warriorButton.TabIndex = 0;
            this.warriorButton.Text = "Warrior";
            this.warriorButton.UseVisualStyleBackColor = true;
            this.warriorButton.Click += new System.EventHandler(this.warriorButton_Click);
            // 
            // archerButton
            // 
            this.archerButton.Location = new System.Drawing.Point(37, 129);
            this.archerButton.Name = "archerButton";
            this.archerButton.Size = new System.Drawing.Size(180, 38);
            this.archerButton.TabIndex = 1;
            this.archerButton.Text = "Archer";
            this.archerButton.UseVisualStyleBackColor = true;
            this.archerButton.Click += new System.EventHandler(this.archerButton_Click);
            // 
            // mageButton
            // 
            this.mageButton.Location = new System.Drawing.Point(37, 85);
            this.mageButton.Name = "mageButton";
            this.mageButton.Size = new System.Drawing.Size(180, 38);
            this.mageButton.TabIndex = 2;
            this.mageButton.Text = "Mage";
            this.mageButton.UseVisualStyleBackColor = true;
            this.mageButton.Click += new System.EventHandler(this.mageButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Weapon:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Element:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Level:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 6;
            // 
            // weaponOutput
            // 
            this.weaponOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weaponOutput.Location = new System.Drawing.Point(324, 45);
            this.weaponOutput.Name = "weaponOutput";
            this.weaponOutput.Size = new System.Drawing.Size(144, 30);
            this.weaponOutput.TabIndex = 7;
            this.weaponOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // elementOutput
            // 
            this.elementOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.elementOutput.Location = new System.Drawing.Point(324, 84);
            this.elementOutput.Name = "elementOutput";
            this.elementOutput.Size = new System.Drawing.Size(144, 30);
            this.elementOutput.TabIndex = 8;
            this.elementOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // levelOutput
            // 
            this.levelOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.levelOutput.Location = new System.Drawing.Point(324, 124);
            this.levelOutput.Name = "levelOutput";
            this.levelOutput.Size = new System.Drawing.Size(144, 30);
            this.levelOutput.TabIndex = 9;
            this.levelOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 216);
            this.Controls.Add(this.levelOutput);
            this.Controls.Add(this.elementOutput);
            this.Controls.Add(this.weaponOutput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mageButton);
            this.Controls.Add(this.archerButton);
            this.Controls.Add(this.warriorButton);
            this.Name = "Form1";
            this.Text = "TEST";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button warriorButton;
        private System.Windows.Forms.Button archerButton;
        private System.Windows.Forms.Button mageButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label weaponOutput;
        private System.Windows.Forms.Label elementOutput;
        private System.Windows.Forms.Label levelOutput;
    }
}

