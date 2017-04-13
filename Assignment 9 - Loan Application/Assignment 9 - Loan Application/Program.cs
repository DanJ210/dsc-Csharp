using ClassLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_9___Loan_Application {
    class Program {
        static double loanAmount;
        static double years;
        static double interestRate;
        static bool done;
        static void Main(string[] args) {

            do {
                done = false;
                try {
                    Console.WriteLine("Please enter loan amount: ");
                    loanAmount = Convert.ToDouble(Console.ReadLine());
                    done = true;
                }
                catch (Exception ex) {
                    Console.WriteLine($"\n{ex.Message}");
                    Console.WriteLine("Please enter a double format.\n");
                }
            } while (!done);

            do {
                done = false;
                try {
                    Console.WriteLine("\nPlease enter years: ");
                    years = Convert.ToDouble(Console.ReadLine());
                    done = true;
                }
                catch (Exception ex) {
                    Console.WriteLine($"\n{ex.Message}");
                    Console.WriteLine("Please enter a double format.\n");
                }
            } while (!done);

            do {
                done = false;
                try {
                    Console.WriteLine("\nPlease enter interest rate: ");
                    interestRate = Convert.ToDouble(Console.ReadLine());
                    done = true;
                }
                catch (Exception ex) {
                    Console.WriteLine($"\n{ex.Message}");
                    Console.WriteLine("Please enter a double format.\n");
                }
            } while (!done);

            

            

            C1 generateInterest = new C1(loanAmount, years, interestRate);
            Console.WriteLine($"\nTotal interest rate: {generateInterest.PayInterests()}");

            Console.WriteLine(generateInterest.iMessage());
        }
    }
}
