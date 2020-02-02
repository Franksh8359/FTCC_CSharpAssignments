namespace Employee_Class
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
            this.employeeListBox = new System.Windows.Forms.ListBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.deptLabel = new System.Windows.Forms.Label();
            this.posLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameOutput = new System.Windows.Forms.Label();
            this.posOutput = new System.Windows.Forms.Label();
            this.deptOutput = new System.Windows.Forms.Label();
            this.idOutput = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeeListBox
            // 
            this.employeeListBox.FormattingEnabled = true;
            this.employeeListBox.Items.AddRange(new object[] {
            "Meyers, S.",
            "Jones, M.",
            "Rodgers, J."});
            this.employeeListBox.Location = new System.Drawing.Point(12, 12);
            this.employeeListBox.Name = "employeeListBox";
            this.employeeListBox.Size = new System.Drawing.Size(123, 134);
            this.employeeListBox.TabIndex = 0;
            this.employeeListBox.SelectedIndexChanged += new System.EventHandler(this.employeeListBox_SelectedIndexChanged);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(10, 50);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(61, 13);
            this.idLabel.TabIndex = 1;
            this.idLabel.Text = "ID Number:";
            // 
            // deptLabel
            // 
            this.deptLabel.AutoSize = true;
            this.deptLabel.Location = new System.Drawing.Point(6, 75);
            this.deptLabel.Name = "deptLabel";
            this.deptLabel.Size = new System.Drawing.Size(65, 13);
            this.deptLabel.TabIndex = 2;
            this.deptLabel.Text = "Department:";
            // 
            // posLabel
            // 
            this.posLabel.AutoSize = true;
            this.posLabel.Location = new System.Drawing.Point(24, 100);
            this.posLabel.Name = "posLabel";
            this.posLabel.Size = new System.Drawing.Size(47, 13);
            this.posLabel.TabIndex = 3;
            this.posLabel.Text = "Position:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(33, 26);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Name:";
            // 
            // nameOutput
            // 
            this.nameOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameOutput.Location = new System.Drawing.Point(77, 20);
            this.nameOutput.Name = "nameOutput";
            this.nameOutput.Size = new System.Drawing.Size(146, 23);
            this.nameOutput.TabIndex = 5;
            this.nameOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // posOutput
            // 
            this.posOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.posOutput.Location = new System.Drawing.Point(77, 95);
            this.posOutput.Name = "posOutput";
            this.posOutput.Size = new System.Drawing.Size(146, 23);
            this.posOutput.TabIndex = 6;
            this.posOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deptOutput
            // 
            this.deptOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deptOutput.Location = new System.Drawing.Point(77, 70);
            this.deptOutput.Name = "deptOutput";
            this.deptOutput.Size = new System.Drawing.Size(146, 23);
            this.deptOutput.TabIndex = 7;
            this.deptOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // idOutput
            // 
            this.idOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idOutput.Location = new System.Drawing.Point(77, 45);
            this.idOutput.Name = "idOutput";
            this.idOutput.Size = new System.Drawing.Size(146, 23);
            this.idOutput.TabIndex = 8;
            this.idOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nameLabel);
            this.groupBox1.Controls.Add(this.idOutput);
            this.groupBox1.Controls.Add(this.idLabel);
            this.groupBox1.Controls.Add(this.deptOutput);
            this.groupBox1.Controls.Add(this.deptLabel);
            this.groupBox1.Controls.Add(this.posOutput);
            this.groupBox1.Controls.Add(this.posLabel);
            this.groupBox1.Controls.Add(this.nameOutput);
            this.groupBox1.Location = new System.Drawing.Point(141, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 134);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Info";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 164);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.employeeListBox);
            this.Name = "Form1";
            this.Text = "Employee Class";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox employeeListBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label deptLabel;
        private System.Windows.Forms.Label posLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label nameOutput;
        private System.Windows.Forms.Label posOutput;
        private System.Windows.Forms.Label deptOutput;
        private System.Windows.Forms.Label idOutput;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

