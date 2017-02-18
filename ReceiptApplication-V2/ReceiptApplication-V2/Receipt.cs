using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptApplication_V2 {
    class Receipt {
        public decimal subTotal { get; set; }
        public decimal tax { get; set; }
        public decimal total { get; set; }
        public void calculateTotal() {
            total = subTotal * tax;
        }
    }
    
}
