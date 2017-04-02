/* Daniel Jackson - Assignment 8 - Inheritance
 * 
 * I did something very different here. I didn't want to just
add class files to a solution because that's so easy and messy.
So I created a seperate (.Net Framework) DLL Class Library and
added the class files that way which makes a portable library
for reuse in the future. */

using DaytonaStateLibrary;
using System;

namespace Assignment_8___Inheritance {
    class Program {
        static void Main(string[] args) {
            // Simple program showing the power of
            // inheritance. Also shows encapsulation of data
            // members. No polymorphism yet.
            Campus atc = new Campus("Advanced Technical College");

            Console.WriteLine(atc.ToString());
        }
    }
}
