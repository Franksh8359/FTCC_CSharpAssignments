using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_and_Combat_Engine
{
    class Player : Mob
    {
        static List<Player> playerList = new List<Player>
            {
                new Player {Name = "Shad", HP = 5000, ATK = 140, DEF = 100, AGL = 75, AIM = 90},
                new Player {Name = "Ivan", HP = 4300, ATK = 85, DEF = 80, AGL = 120, AIM = 135},
                new Player {Name = "Fey", HP = 3700, ATK = 60, DEF = 70, AGL = 90, AIM = 150}
            };

        //chance to multi hit: agl/400
        //how many max: agl/25

        public void SetPlayer(int selected)
        {
            this.Name = playerList[selected].Name;
            this.HP = playerList[selected].HP;
            this.ATK = playerList[selected].ATK;
            this.DEF = playerList[selected].DEF;
            this.AGL = playerList[selected].AGL;
            this.AIM = playerList[selected].AIM;
        }
    }
}
