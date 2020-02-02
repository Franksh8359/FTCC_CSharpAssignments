using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BringIt
{
    class FoodItem : Item
    {
        public FoodItem()
        {
            ItemName = "";
            ItemType = "FOOD";
            Price = 0;
            FeeRate = .05;
        }

        public FoodItem(string n, double pr)
        {
            ItemName = n;
            ItemType = "FOOD";
            Price = pr;
            FeeRate = .20;
        }
    }
}
