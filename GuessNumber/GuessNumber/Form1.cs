using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int currentNumber;
        int guessedNumber;


        private void newNumButton_Click(object sender, EventArgs e) //when you hit the New Number button...
        {
            listBox1.Items.Clear(); //clear the current contents of the listbox
            Random rng = new Random(); //creates a new rng object
            currentNumber = rng.Next(0, 100); //tell the object to pick the next between these two numbers
            listBox1.Items.Add("New number chosen! Guess a number 0-100."); //show output to listbox

        }

        private void submitButton_Click(object sender, EventArgs e) //when you hit the submit button...
        {
            try { guessedNumber = int.Parse(inputBox.Text); } //try to turn the submission into #
            catch { listBox1.Items.Add(inputBox.Text + " is not a whole number. Please try again."); } //catch displays error

            string result; //string contains the result to be shown in listBox

            if (guessedNumber == currentNumber) //if the guessed # equals the current one
            {
                result = "The number " + guessedNumber.ToString() + " is correct! Great work.";
            }
            else if (guessedNumber > currentNumber) //else if it's greater than...
            {
                result = guessedNumber.ToString() + "... Lower!";
            }
            else //otherwise it must be less than.
            {
                result = guessedNumber.ToString() + "... Higher!";
            }

            listBox1.Items.Add(result); //display the result in the listBox.
        }
    }
}
