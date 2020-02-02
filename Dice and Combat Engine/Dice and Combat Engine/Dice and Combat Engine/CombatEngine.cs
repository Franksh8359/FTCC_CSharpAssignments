using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_and_Combat_Engine
{
    class CombatEngine
    {
        private int attackDmg = 0;
        public string output;
        private RandomDie d6_Aim, d6_Attack, d6_Critical;

        public Mob Player { get; set; }
        public Mob Enemy { get; set; }

        public string DoPlayerTurn()
        {
            string output = "";
            d6_Aim = new RandomDie(6);
            d6_Attack = new RandomDie(6);
            d6_Critical = new RandomDie(6);

            d6_Aim.Roll();

            if (d6_Aim.DieResult == 1)
            {
                output = Player.Name + "attacks. Miss!";
                 
            }
            else
            {
                d6_Attack.Roll();
                d6_Critical.Roll();

                attackDmg = Player.ATK + d6_Attack.DieResult;

                if (d6_Critical.DieResult == 1)
                {
                    Enemy.HP -= (attackDmg * 2) - Enemy.DEF;
                    output = Player.Name + "attacks. Critical! " + Enemy.Name + " takes " + attackDmg + " damage.";
                }
                else
                {
                    Enemy.HP -= attackDmg - Enemy.DEF;
                    output = Player.Name + "attacks. " + Enemy.Name + " takes " + attackDmg + " damage.";
                }

            }

            return output;
        }

        public string DoEnemyTurn()
        {
            string output;
            d6_Aim = new RandomDie(6);
            d6_Attack = new RandomDie(6);
            d6_Critical = new RandomDie(6);

            d6_Aim.Roll();

            if (d6_Aim.DieResult == 1)
            {
                output = Enemy.Name + "attacks. Miss!";
            }
            else
            {
                d6_Attack.Roll();
                d6_Critical.Roll();

                attackDmg = Enemy.ATK + d6_Attack.DieResult;

                if (d6_Critical.DieResult == 1)
                {
                    Player.HP -= (attackDmg * 2) - Player.DEF;
                    output = Enemy.Name + "attacks. Critical! " + Player.Name + " takes " + attackDmg + " damage.";
                }
                else
                {
                    Player.HP -= attackDmg - Enemy.DEF;
                    output = Player.Name + "attacks. " + Player.Name + " takes " + attackDmg + " damage.";
                }
            }

            return output;
        }

        public void DoCombatRound()
        {
            if (Player.SPD > Enemy.SPD)
            {
                DoPlayerTurn();
                output += DoPlayerTurn() + "\n";
                if (Player.HP > 0 && Enemy.HP > 0)
                {
                    DoEnemyTurn();
                    output += DoEnemyTurn() + "\n";
                }
            }
            else
            {
                DoEnemyTurn();
                output += DoEnemyTurn() + "\n";
                if (Player.HP > 0 && Enemy.HP > 0)
                {
                    DoPlayerTurn();
                    output += DoPlayerTurn() + "\n";
                }
            }
        }



    }
}
