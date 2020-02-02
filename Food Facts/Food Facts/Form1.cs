/* Name: Holly Franks
 * Date: 3-29-17
 * Tutorial 9-6
 * Here is tutorial 9-6. Here, I created a small program with two forms.
 *      Selecting a food radio on one form displays another with facts
 *      about that food. One form can change the properties on the other
 *      through a property I overlooked initially; Modifiers.
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

namespace Food_Facts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            NutritionForm nutriForm = new NutritionForm();

            if (bananaRadioButton.Checked)
            {
                nutriForm.foodLabel.Text = "1 banana";
                nutriForm.caloriesLabel.Text = "100";
                nutriForm.fatLabel.Text = "0.4";
                nutriForm.carbsLabel.Text = "27";
            }
            else if (popcornRadioButton.Checked)
            {
                nutriForm.foodLabel.Text = "1 cup of air-popped popcorn";
                nutriForm.caloriesLabel.Text = "31";
                nutriForm.fatLabel.Text = "0.4";
                nutriForm.carbsLabel.Text = "6";
            }
            else if (muffinRadioButton.Checked)
            {
                nutriForm.foodLabel.Text = "1 large blueberry muffin";
                nutriForm.caloriesLabel.Text = "385";
                nutriForm.fatLabel.Text = "9";
                nutriForm.carbsLabel.Text = "67";
            }

            nutriForm.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
