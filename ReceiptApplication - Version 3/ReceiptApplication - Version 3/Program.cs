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
                if (Convert.ToInt16(userInput) == 0) {
                    stop = true;
                    continue;
                } else {
                    items[index1, index2] = userInput;
                    index2++;
                }
                Console.WriteLine("Enter Price: ");

                items[index1, index2] = Console.ReadLine();
            } while (stop);
        }

        public decimal calculate(string price, string quantity) {
            decimal op1 = Convert.ToDecimal(price);
            decimal op2 = Convert.ToDecimal(quantity);
            decimal subtotal = op1 * op2;
            return subtotal;
        }
    }

    class Item {

    }
}
