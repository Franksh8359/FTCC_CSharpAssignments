using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeTestApp
{
    public partial class Form1 : Form
    {
        private Employee emp;
        public Form1()
        {
            InitializeComponent();
            //emp = new Employee();
            //emp.Name = "John Smith";
            emp = new Employee("John Smith");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonShowName_Click(object sender, EventArgs e)
        {
            textNameDisplayField.Text = emp.Name;

        }
    }
}
