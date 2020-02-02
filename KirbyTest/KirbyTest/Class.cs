using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KirbyTest
{
    class Class
    {
        private string className = "";
        private string weapon = "";
        private string element = "";
        private int level = 0;

        public string ClassName
        {
            get { return className; }
            set { className = value; }
        }
        public string Weapon
        {
            get { return weapon; }
            set { weapon = value; }
        }
        public string Element
        {
            get { return element; }
            set { element = value; }
        }
        public int Level
        {
            get { return level; }
            set { level = value; }
        }

        public Class(string n, string wep, string ele, int lvl)
        {
            className = n; 
            weapon = wep;
            element = ele;
            level = lvl;
        }
    }
}
