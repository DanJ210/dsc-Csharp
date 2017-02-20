using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_App_V2_Daniel_Jackson {
    class Calculator {
        protected static double operator1;
        protected static double operator2;
        protected static string operand;
        private static double result;
        static void Main(string[] args) {
            Console.Write( "Please Enter First Operator: ");

            operator1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter math: ");

            operand = Console.ReadLine();
            Console.Write("Please enter second operator: ");

            operator2 = Convert.ToDouble(Console.ReadLine());

            switch (operand) {
                case "+":
                    result = addition(operator1, operator2);
                    break;
                case "-":
                    result = subtraction(operator1, operator2);
                    break;
                case "*":
                    result = multiplication(operator1, operator2);
                    break;
                case "/":
                    result = division(operator1, operator2);
                    break;
                default:
                    Console.WriteLine("You did not enter a correct operator, no calculation done.");
                    break;
            }
            Console.WriteLine("Your result is: " + operator1 + " "
                + operand + " " + operator2 + " = " + result);
        }

        public static double addition(double x, double y) {
            double result = x+y;
            return result;
        }
        public static double subtraction(double x, double y) {
            double result = x - y;
            return result;
        }
        public static double division(double x, double y) {
            double result = x / y;
            return result;
        }
        public static double multiplication(double x, double y) {
            double result = x * y;
            return result;
        }
    }
}
