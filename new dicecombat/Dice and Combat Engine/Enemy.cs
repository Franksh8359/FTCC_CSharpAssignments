using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_and_Combat_Engine
{
    class Enemy : Mob
    {
        static List<Mob> enemyList = new List<Mob>
            {
                new Enemy {Name = "Shad", HP = 5000, ATK = 140, DEF = 100, AGL = 85, AIM = 90},
                new Enemy {Name = "Ivan", HP = 4300, ATK = 85, DEF = 80, AGL = 120, AIM = 135},
                new Enemy {Name = "Fey", HP = 3700, ATK = 60, DEF = 70, AGL = 90, AIM = 150 }
            };

        public void SetEnemy(int selected)
        {
            this.Name = enemyList[selected].Name;
            this.HP = enemyList[selected].HP;
            this.ATK = enemyList[selected].ATK;
            this.DEF = enemyList[selected].DEF;
            this.AGL = enemyList[selected].AGL;
            this.AIM = enemyList[selected].AIM;
        }

    }
}

