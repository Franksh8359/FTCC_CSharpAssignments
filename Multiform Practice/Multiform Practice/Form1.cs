/* Name: Holly Franks
 * Date: 3-26-2017
 * Tutorial 9-5
 * Here, I created a small program that displays a new form when you click
 *      a form button. This is practice working with multiple forms.
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

namespace Multiform_Practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dusplayFormButton_Click(object sender, EventArgs e)
        {
            MessageForm myMessageForm = new MessageForm();

            myMessageForm.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
