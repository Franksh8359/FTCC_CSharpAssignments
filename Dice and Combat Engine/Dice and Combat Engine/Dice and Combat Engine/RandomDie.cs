using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_and_Combat_Engine
{
    class RandomDie
    {

        private int _dieSize = 6;
        private int _dieResult = 0;
        private Random _rand;
        public RandomDie()
        {
            _dieSize = 6;
        }

        public RandomDie(int Size)
        {
            _dieSize = Size;
        }

        public int DieSize { get; set; }
        public int DieResult { get { return _dieResult; } }

        public void Roll()
        {
            _dieResult = _rand.Next(_dieSize) + 1;       
        }

    }
}
