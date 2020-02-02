using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BringIt
{
    class Order
    {
        private int orderNumber;
        private string name;
        private string address;
        private List<Item> itemList = new List<Item>();

        private double foodFees = 0;
        private double retailFees = 0;
        private double totalFees = 0;
        private double stateTax = 0;
        private double countyTax = 0;
        private double total = 0;
        private double serviceTotal = 0;
        private double grandTotal = 0;

        private bool valid = false;

        public Order(int no, string n, string add, List<Item> items)
        {
            orderNumber = no;
            name = n;
            address = add;
            itemList = items;
        }

        public int OrderNo { get { return orderNumber; } set { orderNumber = value; } }
        public string Name { get { return name; } set { name = value; }}
        public string Address { get { return address; } set { address = value; } }
        public List<Item> ItemList { get { return itemList; } set { itemList = value; } }

        public double StateTax { get { return stateTax; } set { stateTax = value; } }
        public double CountyTax { get { return countyTax; } set { countyTax = value; } }
        public double FoodFees { get { return foodFees; } set { foodFees = value; } }
        public double RetailFees { get { return retailFees; } set { retailFees = value; } }
        public double TotalFees { get { return totalFees; } set { totalFees = value; } }
        public double Total { get { return total; } set { total = value; } }
        public double ServiceTotal { get { return serviceTotal; } set { serviceTotal = value; } }
        public double GrandTotal { get { return grandTotal; } set { grandTotal = value; } }

        public bool Valid { get { return valid; } set { valid = value; } }
        public string ValidOrder { get { if (valid) { return "VALIDATED ORDER"; } else { return "INVALID ORDER"; } } }

    }
}
