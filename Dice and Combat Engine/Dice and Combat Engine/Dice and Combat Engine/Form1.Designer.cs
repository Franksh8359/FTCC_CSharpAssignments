namespace Dice_and_Combat_Engine
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
            this.battleTextBox = new System.Windows.Forms.RichTextBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.playerHPLabel = new System.Windows.Forms.Label();
            this.enemyHPLabel = new System.Windows.Forms.Label();
            this.nextTurnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // battleTextBox
            // 
            this.battleTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.battleTextBox.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.battleTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.battleTextBox.Location = new System.Drawing.Point(13, 13);
            this.battleTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.battleTextBox.Name = "battleTextBox";
            this.battleTextBox.Size = new System.Drawing.Size(457, 245);
            this.battleTextBox.TabIndex = 0;
            this.battleTextBox.Text = "";
            this.battleTextBox.TextChanged += new System.EventHandler(this.battleTextBox_TextChanged);
            // 
            // resetButton
            // 
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.Location = new System.Drawing.Point(477, 74);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(128, 35);
            this.resetButton.TabIndex = 1;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            // 
            // playerHPLabel
            // 
            this.playerHPLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.playerHPLabel.Location = new System.Drawing.Point(477, 13);
            this.playerHPLabel.Name = "playerHPLabel";
            this.playerHPLabel.Size = new System.Drawing.Size(128, 28);
            this.playerHPLabel.TabIndex = 2;
            this.playerHPLabel.Text = "Player HP:";
            this.playerHPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // enemyHPLabel
            // 
            this.enemyHPLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.enemyHPLabel.Location = new System.Drawing.Point(477, 43);
            this.enemyHPLabel.Name = "enemyHPLabel";
            this.enemyHPLabel.Size = new System.Drawing.Size(128, 28);
            this.enemyHPLabel.TabIndex = 3;
            this.enemyHPLabel.Text = "Enemy HP:";
            this.enemyHPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nextTurnButton
            // 
            this.nextTurnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextTurnButton.Location = new System.Drawing.Point(477, 223);
            this.nextTurnButton.Name = "nextTurnButton";
            this.nextTurnButton.Size = new System.Drawing.Size(128, 35);
            this.nextTurnButton.TabIndex = 4;
            this.nextTurnButton.Text = "Next Turn!";
            this.nextTurnButton.UseVisualStyleBackColor = true;
            this.nextTurnButton.Click += new System.EventHandler(this.nextTurnButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(617, 272);
            this.Controls.Add(this.nextTurnButton);
            this.Controls.Add(this.enemyHPLabel);
            this.Controls.Add(this.playerHPLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.battleTextBox);
            this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Combat Engine";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox battleTextBox;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label playerHPLabel;
        private System.Windows.Forms.Label enemyHPLabel;
        private System.Windows.Forms.Button nextTurnButton;
    }
}

