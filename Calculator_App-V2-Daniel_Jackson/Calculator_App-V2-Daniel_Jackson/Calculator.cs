using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Daniel Jackson - Assignment 4 - Calculator App Version 2
namespace Calculator_App_V2_Daniel_Jackson {
    class Calculator {
        /*
        Playing with protected static variable which I know is not best practice.
        Instructed to make only one file or I would have made a seperate class like
        in previous assignments.
        */
        protected static double operator1;
        protected static double operator2;
        protected static string operand;
        protected static double result;
        protected static bool done = false;
        static void Main(string[] args) {
            bool test;
            // Do while loop runs while boolean variable done = false
            do {
                Console.Write("Please Enter First Operator: ");

                operator1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Please enter math: ");

                operand = Console.ReadLine();
                Console.Write("Please enter second operator: ");

                operator2 = Convert.ToDouble(Console.ReadLine());
                // Switch statement sets bool variable done = true if successful.
                switch (operand) {
                    case "+":
                        result = addition(operator1, operator2);
                        done = true;
                        break;
                    case "-":
                        result = subtraction(operator1, operator2);
                        done = true;
                        break;
                    case "*":
                        result = multiplication(operator1, operator2);
                        done = true;
                        break;
                    case "/":
                        result = division(operator1, operator2);
                        done = true;
                        break;
                    default:
                        Console.WriteLine("You did not enter a correct operator, no calculation done.");
                        break;
                }
            } while (!done);
            
            Console.WriteLine("Your result is: " + operator1 + " "
                + operand + " " + operator2 + " = " + result);
        }
        // Public static members
        // Static only used because I'm not creating a seperate class to instantiate an object.
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
