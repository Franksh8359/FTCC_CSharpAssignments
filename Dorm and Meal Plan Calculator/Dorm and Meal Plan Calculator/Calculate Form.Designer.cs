namespace Dorm_and_Meal_Plan_Calculator
{
    partial class CalculateForm
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
            this.closeButton = new System.Windows.Forms.Button();
            this.totalLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.mealLabel = new System.Windows.Forms.Label();
            this.dormCostLabel = new System.Windows.Forms.Label();
            this.mealCostLabel = new System.Windows.Forms.Label();
            this.dormLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(105, 107);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(80, 82);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(58, 13);
            this.totalLabel.TabIndex = 1;
            this.totalLabel.Text = "Plan Total:";
            // 
            // outputLabel
            // 
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLabel.Location = new System.Drawing.Point(144, 77);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(100, 23);
            this.outputLabel.TabIndex = 2;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mealLabel
            // 
            this.mealLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mealLabel.Location = new System.Drawing.Point(38, 47);
            this.mealLabel.Name = "mealLabel";
            this.mealLabel.Size = new System.Drawing.Size(100, 23);
            this.mealLabel.TabIndex = 5;
            this.mealLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dormCostLabel
            // 
            this.dormCostLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dormCostLabel.Location = new System.Drawing.Point(144, 15);
            this.dormCostLabel.Name = "dormCostLabel";
            this.dormCostLabel.Size = new System.Drawing.Size(100, 23);
            this.dormCostLabel.TabIndex = 6;
            this.dormCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mealCostLabel
            // 
            this.mealCostLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mealCostLabel.Location = new System.Drawing.Point(144, 47);
            this.mealCostLabel.Name = "mealCostLabel";
            this.mealCostLabel.Size = new System.Drawing.Size(100, 23);
            this.mealCostLabel.TabIndex = 7;
            this.mealCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dormLabel
            // 
            this.dormLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dormLabel.Location = new System.Drawing.Point(38, 15);
            this.dormLabel.Name = "dormLabel";
            this.dormLabel.Size = new System.Drawing.Size(100, 23);
            this.dormLabel.TabIndex = 8;
            this.dormLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CalculateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 142);
            this.Controls.Add(this.dormLabel);
            this.Controls.Add(this.mealCostLabel);
            this.Controls.Add(this.dormCostLabel);
            this.Controls.Add(this.mealLabel);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.closeButton);
            this.Name = "CalculateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label totalLabel;
        public System.Windows.Forms.Label outputLabel;
        public System.Windows.Forms.Label mealLabel;
        public System.Windows.Forms.Label dormCostLabel;
        public System.Windows.Forms.Label mealCostLabel;
        public System.Windows.Forms.Label dormLabel;
    }
}