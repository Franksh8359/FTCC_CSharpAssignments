/* This is programming problem 9-5; Retail Item Class.
 * Here, I created a small program that basically uses
 *      a loop to display all the items in an array.
 *      The array properties are in its own class.
 *
 * 4-2-2017
 * CSC 253 0001
 * Holly Franks
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retail_Item_Class
{
    public partial class MainForm : Form
    {
        List<RetailItem> retailItem = new List<RetailItem>
        {
            new RetailItem {Description="Jacket", UnitsOnHand=12, Price=59.95},
            new RetailItem {Description="Jeans", UnitsOnHand=40, Price=34.95},
            new RetailItem {Description="Shirt", UnitsOnHand=20, Price=24.95}
        };

        public MainForm()
        {
            InitializeComponent();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {

            retailListBox.Items.Clear();

            foreach (var item in retailItem)
            {
                retailListBox.Items.Add(item.Description + "\t\t" + item.UnitsOnHand + "\t\t" + item.Price);
            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
