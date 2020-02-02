// Here is programming problem 10-4 in chapter 10. Here, I created a small
//      program that allows the user to view customer records (objects) through
//      their phone numbers. This makes use of a derived customer class from
//      a person class.
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

namespace Person_and_Customer_Classes
{
    public partial class Form1 : Form
    {
        List<Customer> customer = new List<Customer>()
            {
            new Customer { Name = "Belle", Address = "567 Marshmallow Lane", Number = "123-456-7890", IDNo = 19, MaiList = true },
            new Customer { Name = "Jim", Address = "890 Sunny Road", Number = "987-654-3210", IDNo = 25, MaiList = false },
            new Customer { Name = "Tristen", Address = "1234 Olive Street", Number = "245-234-2367", IDNo = 37, MaiList = true }
            };

        public Form1()
        {
            InitializeComponent();

            foreach (var item in customer)
            {
                inputComboBox.Items.Add(item.Number);
            }

        }

        private void inputComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = inputComboBox.SelectedIndex;

            nameOut.Text = customer[index].Name;
            addressOut.Text = customer[index].Address;
            numberOut.Text = customer[index].Number;
            idNoOut.Text = customer[index].IDNo.ToString();
            
            if (customer[index].MaiList == true) { mailListOut.Text = "Yes"; }
            else { mailListOut.Text = "No"; }

        }
    }
}
