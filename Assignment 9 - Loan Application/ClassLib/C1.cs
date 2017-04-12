using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceLib;

namespace ClassLib {
    public class C1 : IMyInterface {
        private double loanAmount { get; set; } = 0.0;
        public double years { get; set; } = 0.0;
        public double interests { get; set; } = 0.0;
        public double interestRate { get; set; } = 0.0;
        //public string iMessage { get; set => throw new NotImplementedException(); }

        public C1(double userLoan, double userYears, double userRate) {
            loanAmount = userLoan;
            years = userYears;
            interestRate = userRate;
        }

        public double PayInterests() {
            return interests = loanAmount * interestRate * years;
        }

        public string iMessage() {
            return "Be Ready!";
        }
    }
}
