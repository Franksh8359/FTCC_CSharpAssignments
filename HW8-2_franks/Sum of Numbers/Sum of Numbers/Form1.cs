// Here is programming problem 8 in chapter 8. Here, I created a small
//          program that lets the user enter a series of numbers. Then the
//          program adds those numbers and displays the sum to the user.
//
// 2-22-2017
// CSC 253
// Holly Franks

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sum_of_Numbers
{
    public partial class SumofNumbers : Form
    {
        public SumofNumbers()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            string input;
            double currentNum;
            double output = 0;

            try
            {
                input = inputTextBox.Text;

                char[] delim = { ',' };
                input = input.Trim();
                string[] tokens = input.Split(delim);

                foreach (string s in tokens)
                {
                    currentNum = Double.Parse(s);
                    output = output + currentNum;
                }
            }
            catch
            { MessageBox.Show("Please enter a series of numbers (separated by commas)."); }

            outputTextBox.Text = output.ToString();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            inputTextBox.Clear();
            outputTextBox.Clear();
            inputTextBox.Focus();
        }
    }
}
