//Test to show my sister how objects work.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KirbyTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Class warrior = new Class("Warrior", "Axe", "Fire", 50);
        Class mage = new Class("Mage", "Staff", "Ice", 40);
        Class archer = new Class("Archer", "Bow", "Wind", 65);

        private void SetJobClass(Class obj)
        {
            weaponOutput.Text = obj.Weapon;
            elementOutput.Text = obj.Element;
            levelOutput.Text = obj.Level.ToString();
        }

        private void warriorButton_Click(object sender, EventArgs e)
        {
            SetJobClass(warrior);
        }

        private void mageButton_Click(object sender, EventArgs e)
        {
            SetJobClass(mage);
        }

        private void archerButton_Click(object sender, EventArgs e)
        {
            SetJobClass(archer);
        }
    }
}
