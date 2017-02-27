using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptApplication___Version_3 {
    class Program {
        static void Main(string[] args) {
            string[,] items = new string[100, 4];
            int index1 = 0, index2 = 0, count = 0;
            string userInput;
            bool stop = false;
            do {
                index2 = 0;
                Console.WriteLine("Enter Item Name: ");
                userInput = Console.ReadLine();
                if (userInput == "0") {
                    stop = true;
                    continue;
                } else {
                    items[index1, index2] = userInput;
                    index2++;
                }
                Console.WriteLine("Enter Price: ");
                
                items[index1, index2] = Console.ReadLine();
                index2++;
                Console.WriteLine("Enter Quantity: ");
                
                items[index1, index2] = Console.ReadLine();
                index2++;
                items[index1, index2] = Convert.ToString(calculate(items[index1, 1], items[index1, 2]));
                index1++;
                count++;
            } while (!stop);

            Console.WriteLine("There are a total of: " + count + " items");
            for (int i = 0; i < count; i++) {
                Console.Write("Item name: " + items[i, 0] + " ");
                Console.Write("Item price: " + items[i, 1] + " ");
                Console.Write("Item quantity: " + items[i, 2] + " ");
                Console.Write("Item subtotal: " + items[i, 3] + " ");
                Console.WriteLine("");
                //for (int i2 = 0; i2 < 4; i2++) {
                //    items[i1, ]
                //}
            }
            Console.WriteLine("Total of all items: " + addTotal(items, count));
            //foreach(string item in items) {
            //    Console.WriteLine(item);
            //    Console.WriteLine(item[0]);
            //    Console.WriteLine(item[1]);
            //    Console.WriteLine(item[2]);
            //    Console.WriteLine(item[3]);
            //}
        }

        // Made a refined function that takes two values from anywhere, even two elements of an array
        // and returns the value of them being multiplied.
        public static decimal calculate(string price, string quantity) {
            decimal op1 = Convert.ToDecimal(price);
            decimal op2 = Convert.ToDecimal(quantity);
            return op1 * op2;
        }

        // Little function or method to add the total of items. Not super necessary but modulates code.
        public static decimal addTotal(string[,] items, int count) {
            decimal total = 0;
            for (int i = 0; i < count; i++) {
                total += Convert.ToDecimal(items[i, 3]);
            }
            return total;
        }
    }
    
}
