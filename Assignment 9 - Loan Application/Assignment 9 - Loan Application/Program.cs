using ClassLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_9___Loan_Application {
    class Program {
        static void Main(string[] args) {
            double loanAmount;
            double years;
            double interestRate;

            Console.WriteLine("Please enter loan amount: ");
            loanAmount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nPlease enter years: ");
            years = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nPlease enter interest rate: ");
            interestRate = Convert.ToDouble(Console.ReadLine());

            C1 generateInterest = new C1(loanAmount, years, interestRate);
            Console.WriteLine($"Total interest rate: {generateInterest.PayInterests()}");

            Console.WriteLine(generateInterest.iMessage());
        }
    }
}
