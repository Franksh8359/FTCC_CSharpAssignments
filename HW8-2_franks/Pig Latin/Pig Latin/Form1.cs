// Here is programming problem 7 in chapter 8. Here, I created a problem that
//      manipulates strings. This program translates a string of text into
//      "Pig Latin" (where the first letter of a word moves to the end along with
//      "ay").
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

namespace Pig_Latin
{
    public partial class PigLatin : Form
    {
        public PigLatin()
        {
            InitializeComponent();
        }

        private string Translate(string str)
        {

            char suffix;
            string word, output;
            char[] delim = { ' ' };
            str = str.Trim();
            string[] tokens = str.Split(delim);

            output = "";

            foreach (string s in tokens)
            {
                string current = s;

                if (s.Length > 1)
                {
                    suffix = current[0];
                    current = current.Remove(0, 1);
                    word = current + suffix + "ay";
                }
                else
                {word = current + "ay";}

                output = output + " " + word;

            }

            output = output.ToUpper();
            return output;

        }

        private void translateButton_Click(object sender, EventArgs e)
        {
            string input, output;
            input = inputTextBox.Text;
            output = Translate(input);

            outputTextBox.Text = output;

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            inputTextBox.Clear();
            outputTextBox.Clear();
            inputTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
