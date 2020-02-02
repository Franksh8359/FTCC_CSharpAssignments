using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_and_Combat_Engine
{
    class Mob
    {
        private string _name; //name of target
        private string _desc; //description, describes the target
        private int _hp; //hitpoints, the target's health
        private int _atk; //attack, the target's base damage dealt
        private int _def; //defense, the target's deduction from attack damage
        private int _agl; //agility/speed, determines target's evasion and if they hit first
        private int _aim; //aim, determines target's critical hit rate

        public Mob()
        {
            _name = "Unknown";
            _desc = "...What's this?";
            _hp = 0;
            _atk = 0;
            _def = 0;
            _agl = 0;
            _aim = 0;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Description
        {
            get { return _desc; }
            set { _desc = value; }
        }
        public int HP
        {
            get { return _hp; }
            set { _hp = value; }
        }
        public int ATK
        {
            get { return _atk; }
            set { _atk = value; }
        }
        public int DEF
        {
            get { return _def; }
            set { _def = value; }
        }
        public int AGL
        {
            get { return _agl; }
            set { _agl = value; }
        }
        public int AIM
        {
            get { return _aim; }
            set { _aim = value; }
        }
    }
}
