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
    public partial class MainForm : Form
    {
        private CombatEngine engine;
        private int selected = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReloadValues();
        }

        private void SetMatch()
        {
            battleTextBox.Text += "You've selected " + engine.Player.Name + " as your character.\n";

            Enemy enemy = new Enemy();
            Random rng = new Random();
            int rngEnemy = rng.Next(3);
            while (rngEnemy == selected) { rngEnemy = rng.Next(3); }

            enemy.SetEnemy(rngEnemy);
            engine.Enemy = enemy;
            battleTextBox.Text += "Your enemy this round is " + enemy.Name + ".\n\n";

            playerHPLabel.Visible = true;
            enemyHPLabel.Visible = true;
            nextTurnButton.Visible = true;
            nextTurnButton.Enabled = true;
            shadButton.Visible = false;
            shadButton.Enabled = false;
            ivanButton.Visible = false;
            ivanButton.Enabled = false;
            feyButton.Visible = false;
            feyButton.Enabled = false;

            playerHPLabel.Text = engine.Player.Name + "'s HP: " + engine.Player.HP.ToString();
            enemyHPLabel.Text = engine.Enemy.Name + "'s HP: " + engine.Enemy.HP.ToString();
            nextTurnButton.Enabled = true;
            nextTurnButton.Focus();

        }

        private void ReloadValues()
        {
            engine = new CombatEngine();

            playerHPLabel.Visible = false;
            enemyHPLabel.Visible = false;
            nextTurnButton.Visible = false;
            nextTurnButton.Enabled = false;
            shadButton.Visible = true;
            shadButton.Enabled = true;
            ivanButton.Visible = true;
            ivanButton.Enabled = true;
            feyButton.Visible = true;
            feyButton.Enabled = true;

            battleTextBox.Clear();
        }

        private void battleTextBox_TextChanged(object sender, EventArgs e)
        {
            battleTextBox.SelectionStart = battleTextBox.Text.Length;
            battleTextBox.ScrollToCaret();
        }

        private void nextTurnButton_Click(object sender, EventArgs e)
        {
            engine.DoCombatRound();
            playerHPLabel.Text = engine.Player.Name + "'s HP: " + engine.Player.HP.ToString();
            enemyHPLabel.Text = engine.Enemy.Name + "'s HP: " + engine.Enemy.HP.ToString();
            battleTextBox.Text = engine.output + "\n";


            if (engine.ongoingBattle == false)
            {
                nextTurnButton.Enabled = false;
                nextTurnButton.Visible = false;
                resetButton.Enabled = true;
                resetButton.Visible = true;
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            ReloadValues();
        }

        private void shadButton_Click(object sender, EventArgs e)
        {
            selected = 0;
            Player player = new Player();
            player.SetPlayer(selected);
            engine.Player = player;
            SetMatch();
        }

        private void ivanButton_Click(object sender, EventArgs e)
        {
            selected = 1;
            Player player = new Player();
            player.SetPlayer(selected);
            engine.Player = player;
            SetMatch();
        }

        private void feyButton_Click(object sender, EventArgs e)
        {
            selected = 2;
            Player player = new Player();
            player.SetPlayer(selected);
            engine.Player = player;
            SetMatch();
        }
    }
}
