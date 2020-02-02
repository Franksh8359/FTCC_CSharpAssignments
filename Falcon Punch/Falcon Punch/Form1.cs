using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Falcon_Punch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void redButton_CheckedChanged(object sender, EventArgs e)
        {
            punchLabel.ForeColor = Color.Red;

        }

        private void blueButton_CheckedChanged(object sender, EventArgs e)
        {
            punchLabel.ForeColor = Color.Blue;
        }

        private void yellowButton_CheckedChanged(object sender, EventArgs e)
        {
            punchLabel.ForeColor = Color.Yellow;
        }
    }
}
