/* This is programming problem 9-6; Dorm and Meal Plan Calculator.
 * Here, I created a small program that allows the user to pick which
 *      hall they will be rooming in as well as the meal plan they
 *      desire. When the user hits calculate, a new form appears
 *      showing the costs associated with their custom plan.
 *      Since I'm not confident with lists and classes, I decided to
 *      use them here for more practice.
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

namespace Dorm_and_Meal_Plan_Calculator
{
    public partial class Form1 : Form
    {
        List<Plan> dorm = new List<Plan>()
        {
            new Plan {PlanName="Allen Hall", Cost=1500},
            new Plan {PlanName="Pike Hall", Cost=1600},
            new Plan {PlanName="Farthing Hall", Cost=1800},
            new Plan {PlanName="University Suites", Cost=2500}
        };

        List<Plan> meal = new List<Plan>()
        {
            new Plan {PlanName="7 meal per week", Cost=600},
            new Plan {PlanName="14 meals per week", Cost=1200},
            new Plan {PlanName="Unlimited meals", Cost=1700}
        };


        public Form1()
        {
            InitializeComponent();
        }

        int dormIndex = 0, mealIndex = 0;
        double total;

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {

            if (dormListBox.SelectedIndex != -1 && mealListBox.SelectedIndex != -1)
            {
                CalculateForm calcForm = new CalculateForm();

                dormIndex = dormListBox.SelectedIndex;
                mealIndex = mealListBox.SelectedIndex;

                total = dorm[dormIndex].Cost + meal[mealIndex].Cost;

                calcForm.dormLabel.Text = dorm[dormIndex].PlanName;
                calcForm.dormCostLabel.Text = dorm[dormIndex].Cost.ToString("c");
                calcForm.mealLabel.Text = meal[mealIndex].PlanName;
                calcForm.mealCostLabel.Text = meal[mealIndex].Cost.ToString("c");
                calcForm.outputLabel.Text = total.ToString("c");

                calcForm.ShowDialog();

            }
            else
            { MessageBox.Show("Please select a dorm and meal plan."); }
            

        }
    }
}
