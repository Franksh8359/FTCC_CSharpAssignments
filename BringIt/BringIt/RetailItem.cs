using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BringIt
{
    class RetailItem: Item
    {
        public RetailItem()
        {
            ItemName = "";
            ItemType = "RETAIL";
            Price = 0;
            FeeRate = .05;
        }

        public RetailItem(string n, double pr)
        {
            ItemName = n;
            ItemType = "RETAIL";
            Price = pr;
            FeeRate = .05;
        }

    }
}
