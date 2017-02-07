using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApplication {
    class Calculator {
        private double opperand1;
        private double opperand2;
        private double result;
        public Calculator() {

        }
        // Optional second constructor
        public Calculator(double var1, double var2) {
            opperand1 = var1;
            this.opperand2 = var2;
        }
        public double op1 {
            get {
                return opperand1;
            }
            set {
                opperand1 = value;
            }
        }
        public double op2 {
            get {
                return opperand2;
            }
            set {
                opperand2 = value;
            }
        }
        // One way of doing it
        public double addition() {
            return result = opperand1 + opperand2;
        }
        // Another way of doing it
        public double addition2() {
            result = opperand1 + opperand2;
            return result;
        }
    }
}
