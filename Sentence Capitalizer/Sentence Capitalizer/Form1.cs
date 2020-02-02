using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sentence_Capitalizer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private string Capitalize(string str)
        {
            string output = "";

            char[] delim = { '.' };
            string[] tokens = str.Split(delim);

            foreach (string s in tokens)
            {
                string sentence = s;
                sentence.TrimStart();
                output += char.ToUpper(sentence[0]);
            }

            return output;

        }

        private void capitalizeButton_Click(object sender, EventArgs e)
        {
            string input = inputTextBox.Text;
            
            outputLabel.Text = Capitalize(input);


        }
    }
}
