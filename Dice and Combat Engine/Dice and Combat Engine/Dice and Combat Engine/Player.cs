using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_and_Combat_Engine
{
    class Player : Mob
    {

        public Player()
        {
            this.Name = "Player";
            this.HP = 100;
            this.ATK = 10;
            this.DEF = 6;
            this.SPD = 15;
        }

    }
}
