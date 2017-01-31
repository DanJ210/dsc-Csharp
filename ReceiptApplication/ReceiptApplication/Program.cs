using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptApplication {
    class Program {
        static void Main(string[] args) {

            // I wanted to play and make an array of the names instead of hard coding them.
            string[] names = new string[] { "Apple", "Orange",
            "Water Melon", "Banana", "Bread", "Lettuce"};
            //decimal subTotal = 0;
            //decimal total = 5;
            //double tax = 0.065; 

            // Creating an array of my objects
            GroceryItem[] items = new GroceryItem[6];
            // Initializing each element of the array to avoid null exception being thrown.
            for (int i = 0; i < items.Length; i++) {
                items[i] = new GroceryItem();
            }
            // Title displayed to the user

            Console.WriteLine("");
            Console.WriteLine("DSC Super Market");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            // Code that collects the amount of each item and the item name from the array
            // of names declared above.
            Console.WriteLine(""); Console.WriteLine("");
            for (int i = 0; i < items.Length; i++) {
                Console.Write("                        " + names[i] + ":   $");
                items[i].cost = Convert.ToDecimal(Console.ReadLine());
                items[i].name = names[i];
            }


            // Gets the subtotal
            Receipt CustomerReceipt = SubTotal(items);
            // Gets total with tax
            CustomerReceipt = tax(CustomerReceipt);
            // Displaying data to screen
            Console.WriteLine("                        ----------------");
            Console.WriteLine("                        SubTotal:   ${0}", String.Format("{0:0.00}", CustomerReceipt.subtotal));
            Console.WriteLine("                        Tax:        ${0}", String.Format("{0:0.00}", CustomerReceipt.tax));
            Console.WriteLine("                        Total:      ${0}", String.Format("{0:0.00}", CustomerReceipt.total));

            /*
            Console.WriteLine("               ${0}",
                String.Format("{0:0.00}", subTotal));
            */
            /*

            Console.Write("                        " + names[0] + ":   $");
            items[0].cost = Convert.ToDecimal(Console.ReadLine());
            items[0].name = names[0];

            Console.Write("                        " + names[1] + ":   $");
            items[1].cost = Convert.ToDecimal(Console.ReadLine()); 
            items[1].name = names[1];

            Console.Write("                        " + names[2] + ":   $");
            items[2].cost = Convert.ToDecimal(Console.ReadLine());
            items[2].name = names[2];

            Console.Write("                        " + names[3] + ":   $");
            items[3].cost = Convert.ToDecimal(Console.ReadLine());
            items[3].name = names[3];

            Console.Write("                        " + names[4] + ":   $");
            items[4].cost = Convert.ToDecimal(Console.ReadLine());
            items[4].name = names[4];

            Console.Write("                        " + names[5] + ":   $");
            items[5].cost = Convert.ToDecimal(Console.ReadLine());
            items[5].name = names[5];
            
            for (int i = 0; i < items.Count(); i++) {
                Console.WriteLine( items[i].name);
                Console.WriteLine( items[i].cost);
            }
            */
            /* Code to format string
            Console.WriteLine("               ${0}",
                String.Format("{0:0.00}", subTotal));
            */
            Console.ReadLine();            
        }

        public static Receipt SubTotal(GroceryItem[] items) {
            decimal subTotal = 0;
            foreach (GroceryItem item in items) {
                subTotal += item.cost;
            }
            Receipt customerReceipt = new Receipt();
            customerReceipt.subtotal = subTotal;
            return customerReceipt;
        }

        public static Receipt tax(Receipt CustomerReceipt) {
            CustomerReceipt.tax = 0.065m;
            CustomerReceipt.total = CustomerReceipt.tax * CustomerReceipt.subtotal;
            return CustomerReceipt;
        }
    }
    // Class that holds the grocery items.
    public class GroceryItem {
        public string name { get; set; }
        public decimal price { get; set; }
        public decimal cost { get; set; }
    }
    // Class that holds the total of items for the receipt
    public class Receipt {
        public decimal subtotal { get; set; }
        public decimal tax { get; set; }
        public decimal total { get; set; }
    }
    
}
