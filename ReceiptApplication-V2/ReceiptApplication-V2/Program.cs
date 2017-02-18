using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptApplication_V2 {
    class Program {
        static void Main(string[] args) {
            int SENTINAL = -1;
            decimal price = 0;
            Item itemList = new Item();
            Receipt customerReceipt = new Receipt();
            customerReceipt.tax = 0.065m;
            itemList.count = 0;
            do {
                itemList.count++;
                Console.Write("Item " + itemList.count + "           Price? ");
                price = Convert.ToDecimal(Console.ReadLine());
                if (price != -1) {
                    itemList.price += price;
                } else {
                    itemList.count -= 1;
                }
            } while (price != SENTINAL);
            customerReceipt.subTotal = itemList.price;
            customerReceipt.calculateTotal();
            Console.WriteLine("");
            Console.WriteLine(itemList.count + " items        SubTotal: ${0}", String.Format("{0:0.00}", customerReceipt.subTotal));
            Console.WriteLine("               Tax:      ${0}", String.Format("{0:0.000}", customerReceipt.tax));
            Console.WriteLine("               Total:    ${0}", String.Format("{0:0.00}", customerReceipt.total));
            Console.WriteLine("");
            //Console.ReadLine();
        }
    }
}
