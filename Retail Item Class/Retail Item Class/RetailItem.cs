using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retail_Item_Class
{
    class RetailItem
    {
        private string _description;
        private int _unitsOnHand;
        private double _price;
        public string Description { get; set; }
        public int UnitsOnHand { get; set; }
        public double Price { get; set; }

    }
}
