using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_4___Receipt_V4 {
    class Program {
        static void Main(string[] args) {
            string[,] items = new string[100, 4];
            int index1 = 0, index2 = 0, count = 0;
            string userInput;

            // Boolean variable is used as the LCV for do/while loop.
            bool stop = false;
            do {
                // index2 resets each iteration because it goes through each column of a single row.
                index2 = 0;
                // Gets name of item
                Console.WriteLine("Enter Item Name: ");
                userInput = Console.ReadLine();
                // Checks user input for value other than 0.
                if (userInput == "0") {
                    // If user inputs 0 then LCV changes to true and continue keyword
                    // takes program to evaluation of LCV. Else adds it to name
                    stop = true;
                    continue;
                }
                else {
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
            }
            Console.WriteLine("Total of all items: " + addTotal(items, count));
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
