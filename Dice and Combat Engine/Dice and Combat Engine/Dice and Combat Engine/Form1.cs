using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dice_and_Combat_Engine
{
    public partial class Form1 : Form
    {
        private CombatEngine engine;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            engine = new CombatEngine();
            nextTurnButton.Focus();

        }

        private void battleTextBox_TextChanged(object sender, EventArgs e)
        {
            battleTextBox.SelectionStart = battleTextBox.Text.Length;
            battleTextBox.ScrollToCaret();
        }

        private void nextTurnButton_Click(object sender, EventArgs e)
        {
            engine.DoCombatRound();
            playerHPLabel.Text = "Player HP:\t" + engine.Player.HP.ToString();
            enemyHPLabel.Text = "Enemy HP:\t" + engine.Enemy.HP.ToString();
            battleTextBox.Text = engine.output + "\n";
        }
    }
}
