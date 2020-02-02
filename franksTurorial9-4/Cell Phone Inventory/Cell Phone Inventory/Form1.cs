/* Name: Holly Franks
 * Date: 3-26-2017
 * Tutorial 9-4
 * Here is tutorial 9-4. Here, I coded a Cell Phone Inventory tracker of sorts.
 *     From my understanding, I coded this program to take the user's input, 
 *     pass it through a class, and create an object in a list with the data
 *     according to the class... Then, you can view the inventory object's price 
 *     by clicking it in the listbox. It's hard to explain what's going on, but
 *     it makes sense.
 *     I'm thinking this concept will help me create an inventory for my text 
 *     adventure later on...!
 */
 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cell_Phone_Inventory
{
    public partial class Form1 : Form
    {
        List<CellPhone> phoneList = new List<CellPhone>();

        public Form1()
        {
            InitializeComponent();
        }

        private void GetPhoneData(CellPhone phone)
        {
            decimal price;

            phone.Brand = brandTextBox.Text;
            phone.Model = modelTextBox.Text;

            if (decimal.TryParse(priceTextBox.Text, out price))
            {
                phone.Price = price;
            }
            else
            {
                MessageBox.Show("Invalid price");
            }
        }

        private void addPhoneButton_Click(object sender, EventArgs e)
        {
            CellPhone myPhone = new CellPhone();
            GetPhoneData(myPhone);
            phoneList.Add(myPhone);
            phoneListBox.Items.Add(myPhone.Brand + " " + myPhone.Model);

            brandTextBox.Clear();
            modelTextBox.Clear();
            priceTextBox.Clear();
            brandTextBox.Focus();
        }

        private void phoneListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = phoneListBox.SelectedIndex;
            MessageBox.Show(phoneList[index].Price.ToString("c"));
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
