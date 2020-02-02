using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_and_Combat_Engine
{
    class CombatEngine
    {
        private double attackDmg = 0;
        public string output;
        Random rng = new Random();
        public Boolean ongoingBattle = true;

        public Player Player { get; set; }
        public Enemy Enemy { get; set; }

        public string CheckHP()
        {
            string output = "";

            if (Player.HP <= 0)
            {
                Player.HP = 0;
                ongoingBattle = false;
                output += Player.Name + "'s HP is 0! " + Player.Name + " is defeated.\nPress Reset to start a new round!\n\n";
            }

            if (Enemy.HP <= 0)
            {
                Enemy.HP = 0;
                ongoingBattle = false;
                output += Enemy.Name + "'s HP is 0! " + Enemy.Name + " is defeated.\nPress Reset to start a new round!\n\n";
            }

            return output;
        }

        public string DoTurn(Mob attacker, Mob defender)
        {
            string output = "";

            int rngMiss = rng.Next(1350);

            if (rngMiss <= defender.AGL) { output += attacker.Name + " attacks. Miss!"; }

            else
            {
                double baseDmg = attacker.ATK * 2;

                //chance to multi hit: agl/400
                //how many max: agl/25

                int rngMulti = rng.Next(401);

                if (rngMulti <= attacker.AGL)
                {
                    int rngHits = rng.Next(2, attacker.AGL / 25);
                    int total = 0;

                    output += attacker.Name + " attacks " + rngHits + " times:\n";

                    for (int i = 1; i <= rngHits; i++)
                    {
                        int rngCrit = rng.Next(1450);
                        int rngDamage = rng.Next(30);

                        if (rngCrit <= attacker.AIM)
                        {
                            attackDmg = baseDmg * 1.5 + rngDamage - defender.DEF;
                            Enemy.HP -= (int)Math.Round(attackDmg);
                            output += attackDmg + " (Critical!)\n";
                            total += (int)Math.Round(attackDmg);
                        }
                        else
                        {
                            attackDmg = baseDmg + rngDamage - defender.DEF;
                            Enemy.HP -= (int)Math.Round(attackDmg);
                            output += attackDmg + "\n";
                            total += (int)Math.Round(attackDmg);
                        }
                    }

                    output += defender.Name + " takes a total of " + total + " damage.";

                }
                else
                {
                    int rngCrit = rng.Next(1450);
                    int rngDamage = rng.Next(100);

                    if (rngCrit <= attacker.AIM)
                    {
                        attackDmg = baseDmg * 1.5 + rngDamage - defender.DEF;
                        defender.HP -= (int)Math.Round(attackDmg);
                        output += attacker.Name + " attacks. Critical! " + defender.Name + " takes " + attackDmg + " damage.";
                    }
                    else
                    {
                        attackDmg = baseDmg + rngDamage - Enemy.DEF;
                        defender.HP -= (int)Math.Round(attackDmg);
                        output += attacker.Name + " attacks. " + defender.Name + " takes " + attackDmg + " damage.";
                    }
                }

            }

        if (CheckHP() != "")
        { output += "\n" + CheckHP(); }
        return output;
    }

        public void DoCombatRound()
        {
            if (Player.AGL > Enemy.AGL)
            {
                if (ongoingBattle == true)
                {
                    output += DoTurn(Player, Enemy) + "\n";
                }
                if (ongoingBattle == true)
                {
                    output += DoTurn(Enemy, Player) + "\n";
                }

            }

            else
            {
                if (ongoingBattle == true)
                {
                    output += DoTurn(Enemy, Player) + "\n";
                }
                if (ongoingBattle == true)
                {
                    output += DoTurn(Player, Enemy) + "\n";
                }
            }
        }



    }
}
