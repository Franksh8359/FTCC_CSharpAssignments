/* This is Programming Problem 9-4, Employee Class. Here, I coded a program to display employee
 * info when the employee is selected in the listbox.However, the challenge was to create
 * an employee class, then create three employee objects and set their properties through
 * that class... (Or something.) As a personal challenge, I wanted to created a listbox and
 * match the selected index up to the object list's index... But I wasn't sure how to make
 * a list of objects with the class properties. After several hours, I finally found a way.
 *
 * 3-29-2017
 * CSC 253
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

namespace Employee_Class
{
    public partial class Form1 : Form
    {

        List<Employee> employee = new List<Employee>()
        {
            new Employee {Name="Susan Meyers", IdNumber=47899, Department="Accounting", Position="Vice President"},
            new Employee {Name="Mark Jones", IdNumber=39119, Department="IT", Position="Programmer"},
            new Employee {Name="Joy Rodgers", IdNumber=81774, Department="Manufacturing", Position="Engineer"}
        };

        public Form1()
        {
            InitializeComponent();
        }

        int index = 0;

        private void employeeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            index = employeeListBox.SelectedIndex;

            nameOutput.Text = employee[index].Name;
            idOutput.Text = employee[index].IdNumber.ToString();
            deptOutput.Text = employee[index].Department;
            posOutput.Text = employee[index].Position;
            
        }
    }
}
