// Here is tutorial 9-1. Here, I created a small program that (virtually)
//          flips a coin five times, then displays the results of those
//          coin flips in a listbox. This is practice with new classes.
//
// 3-1-2017
// CSC 253
// Holly Franks

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Coin_Toss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tossButton_Click(object sender, EventArgs e)
        {
            Coin myCoin = new Coin();

            outputListBox.Items.Clear();

            for (int count = 0; count < 5; count++)
            {
                myCoin.Toss();

                outputListBox.Items.Add(myCoin.GetSideUp());
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
