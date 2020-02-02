// This is programming problem 10-1. Here, I created a small program
//      that allows the use to create an object, a production worker,
//      derived from the employee class. The program then displays
//      the newly created object back to the user.
//
// 4-19-2017
// CSC 253 0001
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

namespace Employee_and_ProductionWorker_Classes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            shiftIn.SelectedIndex = 0;
        }

        private void GetEmployeeData(ProductionWorker employee)
        {
            int number;
            double pay;

            employee.Name = nameIn.Text;

            employee.Shift = int.Parse(shiftIn.Text);

            if (int.TryParse(numIn.Text, out number))
            {
                if (double.TryParse(payIn.Text, out pay))
                {
                    employee.Number = number;
                    employee.PayRate = pay;
                }
                else { MessageBox.Show("Please enter a valid ID number for the employee."); }
            }
            else { MessageBox.Show("Please enter a valid hourly wage for the employee."); }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            ProductionWorker employee = new Employee_and_ProductionWorker_Classes.ProductionWorker();
            GetEmployeeData(employee);

            nameOut.Text = employee.Name;
            numOut.Text = employee.Number.ToString();
            shiftOut.Text = employee.Shift.ToString();
            payOut.Text = employee.PayRate.ToString("c");

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            nameIn.Text = "";
            numIn.Text = "";
            shiftIn.SelectedIndex = 0;
            payIn.Text = "";
            nameIn.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
