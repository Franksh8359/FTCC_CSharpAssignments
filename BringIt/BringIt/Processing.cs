using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BringIt
{
    class Processing
    {
        //tax rates and order list
        private double STATETAXRATE = 0.0475;
        private double COUNTYTAXRATE = 0.0225;
        private List<Order> OrderList = new List<Order>();

        public Processing() { }

        //processes all totals for the order provided
        private string processTotals(Order order)
        {
            foreach(Item item in order.ItemList)
            {
                order.Total += item.Price;
                if (item is FoodItem) { order.FoodFees += item.Price * item.FeeRate; }
                else { order.RetailFees += item.Price * item.FeeRate; }
            }
            order.RetailFees = Math.Round(order.RetailFees, 2);
            order.FoodFees = Math.Round(order.FoodFees, 2);
            order.TotalFees = Math.Round(order.FoodFees + order.RetailFees, 2);
            order.ServiceTotal = order.TotalFees + order.Total;
            if (order.ServiceTotal >= 10.0) { order.Valid = true; }
            order.StateTax = Math.Round(STATETAXRATE * order.ServiceTotal, 2);
            order.CountyTax = Math.Round(COUNTYTAXRATE * order.ServiceTotal, 2);
            order.GrandTotal = order.ServiceTotal + order.StateTax + order.CountyTax;
            return "Bill processed for order #" + order.OrderNo + ".";
        }

        //creates the customer receipt for the order
        public string createReceipt(int count, Order order)
        {
            try
            {
                string fileName = "receipt" + count + ".txt";
                if (File.Exists(fileName)) { File.Delete(fileName); }

                var lines = new List<string>();
                string[] header = { "", "",
                    "ORDER#" + order.OrderNo.ToString(),
                    "",
                    order.Name,
                    order.Address,
                    "", "----------------------------------",
                    order.ValidOrder,
                    "----------------------------------", "",
                    "Order:"};
                lines.AddRange(header);

                foreach (Item item in order.ItemList)
                {
                    lines.Add(item.ItemName + "\t\t\t$" + item.Price);
                }

                string[] footer = {"", "----------------------------------",
                    "Item Total: \t\t\t\t$" + order.Total.ToString(),
                    "Service Fee: \t\t\t\t$" + order.TotalFees.ToString(),
                    "Order Total: \t\t\t\t$" + order.ServiceTotal.ToString(),
                    "----------------------------------",
                    "County Tax \t\t\t\t$" + order.CountyTax.ToString(),
                    "State Tax: \t\t\t\t$" + order.StateTax.ToString(),
                    "----------------------------------",
                    "GRAND TOTAL: \t\t\t\t$" + order.GrandTotal.ToString()};
                lines.AddRange(footer);
                File.WriteAllLines(fileName, lines);
                return "The receipt was created for order #" + count;
            }
            catch (Exception ex) { return "ERROR! Receipt for order #" + order.OrderNo + " cannot be exported. Please ensure the directory is not in use."; }

        }

        //processes the information from each input file found; assumes there are no more files if the next numbered input file can't be found
        public List<string> processInput()
        {
            var msgList = new List<string>();

            int no = 0;
            string name = "";
            string address = "";

            string itemName = "";
            string itemType = "";
            double itemPrice = 0;

            bool remainingFiles = true;
            int fileCount = 0;

            try
            {
                StreamReader inputFile;

                while (remainingFiles)
                {
                    if (File.Exists("input" + fileCount + ".txt"))
                    {
                        List<Item> items = new List<Item>();
                        inputFile = File.OpenText("input" + fileCount + ".txt");
                        msgList.Add("input" + fileCount + ".txt found!");
                        msgList.Add("Processing order...");

                        no = int.Parse(inputFile.ReadLine());
                        name = inputFile.ReadLine();
                        address = inputFile.ReadLine();
                        inputFile.ReadLine();

                        while (inputFile.EndOfStream == false)
                        {
                            itemName = inputFile.ReadLine();
                            itemType = inputFile.ReadLine();
                            itemPrice = double.Parse(inputFile.ReadLine());

                            if (itemType == "RETAIL") { Item item = new RetailItem(itemName, itemPrice); items.Add(item); }
                            else if (itemType == "FOOD") { Item item = new FoodItem(itemName, itemPrice); items.Add(item); }
                            inputFile.ReadLine();
                        }

                        Order order = new Order(no, name, address, items);
                        OrderList.Add(order);
                        msgList.Add("Order #" + order.OrderNo + " imported!");
                        inputFile.Close();

                    }
                    else { remainingFiles = false; }

                    fileCount += 1;
                }

                msgList.Add("Complete! All orders found have been imported.");
                msgList.Add("If files were not listed, please ensure input files");
                msgList.Add("are in the same directory as the executable.");
            }
            catch (Exception ex)
            {
                msgList.Add("ERROR! Input files found, but could not be imported.");
                msgList.Add("Please ensure the files are intact and the directory is not in use.");
            }
            return msgList;
        }

        //takes all the orders and creates receipts as well as a master input file that contains order information for the company
        public List<string> processOrders()
        {
            var msgList = new List<string>();
            int count = 0;
            msgList.Add("Processing receipts...");

            string fileName = "output.txt";
            try
            {
                if (File.Exists(fileName)) { File.Delete(fileName); }
                msgList.Add("output.txt file created!");
            }
            catch (Exception ex) { msgList.Add("ERROR: The output.txt file could not be created."); }
            StreamWriter outputFile;
            outputFile = File.CreateText(fileName);
            outputFile.Close();

            foreach (var order in OrderList)
            {
                processTotals(order);
                msgList.Add("Order #" + order.OrderNo + " has been processed.");
                msgList.Add(createReceipt(count, order));
                count += 1;

                var lines = new List<string>();
                lines.Add(order.OrderNo.ToString());
                lines.Add(order.ValidOrder);
                lines.Add("Bill to Cust: $" + order.GrandTotal);
                lines.Add("NC State Sales Tax: $" + order.StateTax);
                lines.Add("Cumberland Co. Sales Tax: $" + order.CountyTax);
                lines.Add("Delivery Charges: $" + order.TotalFees);
                lines.Add("Cost for Restaurant $" + (order.FoodFees / 2));
                lines.Add("");
                try
                {
                    outputFile = File.AppendText(fileName);
                    foreach (string line in lines) { outputFile.WriteLine(line); }
                    outputFile.Close();
                }
                catch (Exception ex) { msgList.Add("ERROR! Could not append output.txt data. Please ensure the directory is not in use."); }
            }

            msgList.Add("Complete! All orders have been processed.");
            return msgList;
        }
    }
}
