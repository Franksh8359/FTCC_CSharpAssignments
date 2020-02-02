using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BringIt
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void processButton_Click(object sender, EventArgs e)
        {
            Processing processing = new Processing();

            foreach (var msg in processing.processInput()) { outputListBox.Items.Add(msg); }
            foreach (var msg in processing.processOrders()) { outputListBox.Items.Add(msg); }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            outputListBox.Items.Clear();
        }
    }
}
