// This is tutorial 10-1 in Chapter 10. Here, I coded a program that
//      takes the user's input, gets and sets that input to a class
//      (and its subclass), then displays that set data back to the
//      user as output.
//
// 4-12-2017
// CSC 253 0001
// Holly Franks

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CD_Account_Test
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void GetCDData(CDAccount account)
        {
            decimal interestRate;
            decimal balance;

            account.AccountNumber = accountNumberTextBox.Text;
            account.MaturityDate = maturityDateTextBox.Text;

            if (decimal.TryParse(interestRateTextBox.Text, out interestRate))
            {
                account.InterestRate = interestRate;

                if (decimal.TryParse(balanceTextBox.Text, out balance))
                {
                    account.Balance = balance;
                }
                else { MessageBox.Show("Invalid balance"); }
            }
            else { MessageBox.Show("Invalid interest rate"); }
        }

        private void createObjectButton_Click(object sender, EventArgs e)
        {
            CDAccount myAccount = new CD_Account_Test.CDAccount();
            GetCDData(myAccount);

            accountNumberLabel.Text = myAccount.AccountNumber;
            interestRateLabel.Text = myAccount.InterestRate.ToString("n2");
            balanceLabel.Text = myAccount.Balance.ToString("c");
            maturityDateLabel.Text = myAccount.MaturityDate;

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
