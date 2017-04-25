using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment_11 {
    class Program {
        static void Main(string[] args) {
            string userName = null;
            //Regex namePattern = new Regex("\b[a-zA-Z]{2,15}\s[a-zA-Z]{2,15}\b");
            // The above was copied directly from the content but it gave a syntax error.
            // I had to modify it to get it to work but it doesn't work as intended.
            Regex namePattern = new Regex("\b[a-zA-Z]{2,15}\\s[a-zA-Z]{2,15}\b");
            Regex numberPattern = new Regex("^[0-9]{12,19}$");
            string cardNumber = null;


            // The name part here does not work with the above pattern but the 
            // credit card part does work.
            bool done = false;
            int count = 0;
            do {

                Console.WriteLine("Please enter your name: " + (count > 0 ? " (Only letters can be used)" : ""));
                userName = Console.ReadLine();
                count++;
                //Console.WriteLine(namePattern.IsMatch(userName));
                //Console.WriteLine(namePattern.Match(userName));
                //done = namePattern.IsMatch(userName) ? true : false;
            } while (done);

            // The logic below does work but the above does not
            done = false;
            count = 0;
            do {
                Console.WriteLine("Please enter credit card number");
                cardNumber = Console.ReadLine();
                count++;
                done = numberPattern.IsMatch(cardNumber);
                //Console.WriteLine(numberPattern.IsMatch(cardNumber));
            } while (!done);
        }
    }
}
