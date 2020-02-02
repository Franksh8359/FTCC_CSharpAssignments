using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_and_Combat_Engine
{
    class Enemy : Mob
    {

        public Enemy()
        {
            this.Name = "Enemy";
            this.HP = 100;
            this.ATK = 15;
            this.DEF = 4;
            this.SPD = 10;
        }

    }
}
