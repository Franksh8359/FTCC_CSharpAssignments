// This is programming challenges 1 and 2 in chapter 8.
// Here, I created a program that takes a string of input from the user, then
//      calculates 1) how many words are in that string and 2) the average
//      of letters in each word.
// This assignment was pretty tough for me, but I figured it out on my own. I
//      didn't really have too many sources to work from. It was a lot
//      of trial and error.
//
// 2-18-2017
// CSC 253
// Holly Franks

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Word_Counter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int CountWords(String str)
        {
            int wordCount = 0;

            char[] delim = { ' ' };
            string[] tokens = str.Split(delim);

            foreach (string s in tokens)
            { wordCount++; }

            return wordCount;      
        }

        private double Average(String str)
        {
            double wordCount = 0;
            double charCount = 0;
            double average;

            char[] delim = { ' ' };
            string[] tokens = str.Split(delim);

            foreach (string s in tokens)
            { wordCount++;
                foreach (char ch in s)
                { charCount++; }
            }

            average = charCount / wordCount;

            return average;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int words;
            double average;

            string input = inputTextBox.Text.Trim();

            words = CountWords(input);
            wordsOutputLabel.Text = words.ToString();
            average = Average(input);
            averageOutputLabel.Text = average.ToString();

        }
    }
}
