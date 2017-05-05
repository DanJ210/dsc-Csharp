/* Daniel Jackson - Exam 4 - Receipt Version 4 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exam_4___Receipt_V4 {
    class Program {
        static void Main(string[] args) {
            // Logic variables.
            string[,] items = new string[100, 4];
            int index1 = 0, index2 = 0, count = 0;
            decimal tax = .06m;
            // Regex patterns.
            string itemPattern = "[a-zA-Z0-9&( )_.+-]";
            string pricePattern = "[0-9]";
            string quantityPattern = "[0-9.]";
            // User input variables and error message.
            string itemInput, priceInput, quantityInput, extraMessage = "";

            // Boolean variables used as the LCV for do/while loops.
            bool valid, stop = false;
            //bool stop = false;
            do {
                // index2 resets each iteration because it goes through each column of a single row.
                index2 = 0;
                do {
                    // Gets input for item name and checks if valid
                    Console.WriteLine("Enter Item Name: (Enter 0 to Quit)" + extraMessage);
                    itemInput = Console.ReadLine();
                    valid = myInputValidator(itemInput, itemPattern);

                    // If input is valid then stores in array and continues.
                    // If LCV is entered then program will end.
                    if (valid) {
                        if (itemInput == "0") {
                            stop = true;
                            continue;
                        }
                        else {
                            items[index1, index2] = itemInput;
                            index2++;
                            valid = true;
                            extraMessage = "";
                        }
                    } else {
                        extraMessage = " **Invalid Input Error**";
                    }
                    
                } while (!valid && !stop);

                // Collects price for item if input is valid.
                if (!stop) {
                    do {
                        Console.WriteLine("Enter Price:" + extraMessage);
                        priceInput = Console.ReadLine();
                        valid = myInputValidator(priceInput, pricePattern);
                        if (valid) {
                            items[index1, index2] = priceInput;
                            index2++;
                            extraMessage = "";
                        }
                        else {
                            extraMessage = " **Invalid Input Error**";
                        }
                    } while (!valid);

                    // Collects quantity for item if input is valid.
                    do {
                        Console.WriteLine("Enter Quantity: " + extraMessage);
                        quantityInput = Console.ReadLine();
                        valid = myInputValidator(quantityInput, quantityPattern);
                        if (valid) {
                            items[index1, index2] = quantityInput;
                            index2++;
                            extraMessage = "";
                        }
                        else {
                            extraMessage = " **Invalid Input Error**";
                        }
                    } while (!valid);

                    // Try block to make sure quantity is valid. Meaning "." is not the only entry, must have at least 1 number.
                    // If error, then error is displayed and user can try again.
                    try {
                        items[index1, index2] = Convert.ToString(calculate(items[index1, 1], items[index1, 2]));
                    } catch (Exception ex) {
                        Console.WriteLine("Please enter correct number format for quantity");
                        continue;
                    }
                    
                    // Next item collection in the array.
                    index1++;
                    // Counts amount of times items entered successfully.
                    count++;
                }
            } while (!stop);

            // Output area when the user is finished inputting items.
            Console.WriteLine("\n*************************-Item Summary-********************");
            Console.WriteLine("There are a total of: " + count + " items\n");
            for (int i = 0; i < count; i++) {
                Console.Write("Item name: " + items[i, 0] + " - ");
                Console.Write("Item price: {0:C}", Convert.ToDecimal(items[i, 1]));
                Console.Write(" - ");
                Console.Write("Item quantity: " + items[i, 2]);
                Console.Write(" - ");
                Console.Write("Item subtotal: {0:C}", Convert.ToDecimal(items[i, 3]));
                Console.WriteLine("");
            }
            Console.WriteLine("\n*************************-Total Summary-********************\n");
            Console.WriteLine("Total of all items: {0:C}", addTotal(items, count));
            Console.WriteLine("State Tax: {0:C}", tax);
            Console.WriteLine("Total with Tax: {0:C}", addTax(addTotal(items, count), tax));
        }

        /// <summary>
        /// Calculates price of item * quanity.
        /// </summary>
        /// <param name="price">string of user entered price</param>
        /// <param name="quantity">string of user entered quantity</param>
        /// <returns>decimal after values get converted and multiplied.</returns>
        public static decimal calculate(string price, string quantity) {
            decimal op1 = Convert.ToDecimal(price);
            decimal op2 = Convert.ToDecimal(quantity);
            return op1 * op2;
        }

        /// <summary>
        /// Calculates total of all item prices.
        /// </summary>
        /// <param name="items">string[,] of items</param>
        /// <param name="count">int of amount of entered items to calculate</param>
        /// <returns>decimal</returns>
        public static decimal addTotal(string[,] items, int count) {
            //decimal tax = .06m;
            decimal total = 0;
            for (int i = 0; i < count; i++) {
                total += Convert.ToDecimal(items[i, 3]);
            }
            return total;
        }

        /// <summary>
        /// Function to add tax and other additions.
        /// </summary>
        /// <param name="total">decimal of items * quantity</param>
        /// <param name="tax">decimal of state tax</param>
        /// <returns></returns>
        public static decimal addTax(decimal total, decimal tax) {
            return total + total * tax;
        }

        /// <summary>
        /// Function for input validation that returns true or false.
        /// </summary>
        /// <param name="input">User Input String</param>
        /// <param name="pattern">Pattern String</param>
        /// <returns>boolean if given parameters are valid</returns>
        public static bool myInputValidator(string input, string pattern) {
            var testObject = Regex.Matches(input, pattern);
            if (testObject.Count == input.Count()) {
                return true;
            } else {
                return false;
            }
        }
    }
}
