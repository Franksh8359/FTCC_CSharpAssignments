using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BringIt
{
    class Item
    {
        private string itemName;
        private string itemType;
        private double price;
        private double feeRate = 0;

        public string ItemName { get { return itemName; } set { itemName = value; } }
        public string ItemType { get { return itemType; } set { itemType = value; } }
        public double Price { get { return price; } set { price = value; } }
        public double FeeRate { get { return feeRate; } set { feeRate = value; } }
    }
}
