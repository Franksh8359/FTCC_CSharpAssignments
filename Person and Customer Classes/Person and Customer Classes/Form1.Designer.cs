namespace Person_and_Customer_Classes
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nameOut = new System.Windows.Forms.Label();
            this.addressOut = new System.Windows.Forms.Label();
            this.numberOut = new System.Windows.Forms.Label();
            this.idNoOut = new System.Windows.Forms.Label();
            this.mailListOut = new System.Windows.Forms.Label();
            this.inputComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.inputComboBox);
            this.groupBox1.Location = new System.Drawing.Point(22, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 76);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select a Customer Record:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mailListOut);
            this.groupBox2.Controls.Add(this.idNoOut);
            this.groupBox2.Controls.Add(this.numberOut);
            this.groupBox2.Controls.Add(this.addressOut);
            this.groupBox2.Controls.Add(this.nameOut);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(22, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(261, 192);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer Data:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Customer ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mail List:";
            // 
            // nameOut
            // 
            this.nameOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameOut.Location = new System.Drawing.Point(94, 31);
            this.nameOut.Name = "nameOut";
            this.nameOut.Size = new System.Drawing.Size(143, 24);
            this.nameOut.TabIndex = 5;
            this.nameOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addressOut
            // 
            this.addressOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addressOut.Location = new System.Drawing.Point(94, 60);
            this.addressOut.Name = "addressOut";
            this.addressOut.Size = new System.Drawing.Size(143, 24);
            this.addressOut.TabIndex = 6;
            this.addressOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numberOut
            // 
            this.numberOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numberOut.Location = new System.Drawing.Point(94, 88);
            this.numberOut.Name = "numberOut";
            this.numberOut.Size = new System.Drawing.Size(143, 24);
            this.numberOut.TabIndex = 7;
            this.numberOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // idNoOut
            // 
            this.idNoOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idNoOut.Location = new System.Drawing.Point(94, 117);
            this.idNoOut.Name = "idNoOut";
            this.idNoOut.Size = new System.Drawing.Size(143, 24);
            this.idNoOut.TabIndex = 8;
            this.idNoOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mailListOut
            // 
            this.mailListOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mailListOut.Location = new System.Drawing.Point(94, 145);
            this.mailListOut.Name = "mailListOut";
            this.mailListOut.Size = new System.Drawing.Size(143, 24);
            this.mailListOut.TabIndex = 9;
            this.mailListOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputComboBox
            // 
            this.inputComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputComboBox.FormattingEnabled = true;
            this.inputComboBox.Location = new System.Drawing.Point(23, 32);
            this.inputComboBox.Name = "inputComboBox";
            this.inputComboBox.Size = new System.Drawing.Size(214, 21);
            this.inputComboBox.TabIndex = 0;
            this.inputComboBox.SelectedIndexChanged += new System.EventHandler(this.inputComboBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 309);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Person and Customer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox inputComboBox;
        private System.Windows.Forms.Label mailListOut;
        private System.Windows.Forms.Label idNoOut;
        private System.Windows.Forms.Label numberOut;
        private System.Windows.Forms.Label addressOut;
        private System.Windows.Forms.Label nameOut;
    }
}

