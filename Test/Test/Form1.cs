using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        string name;
        int level;
        string job;
        string output;

        private void goButton_Click(object sender, EventArgs e)
        {
            if (smnRadio.Checked)
            {
                job = "Summoner";
            }
            else if (ninRadio.Checked)
            {
                job = "Ninja";
            }
            else
            {
                job = "Dragoon";
            }

            name = nameInput.Text;

            level = int.Parse(levelInput.Text);

            output = "The character " + name + " is a level " + level + " " + job + ". Radical!";

            outputTextBox.Text = output;

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
