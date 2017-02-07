using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApplication {
    class CalculatorRun {
        static void Main(string[] args) {

            Calculator userCalc = new Calculator();
            Console.Write("Please enter first opperand: ");
            userCalc.op1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter second opperand: ");
            userCalc.op2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("The end result is: " +
                userCalc.addition());
            // Pause at the end of the application
            Console.ReadLine();
        }
    }
}
