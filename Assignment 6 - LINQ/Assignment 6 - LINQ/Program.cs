/// I wanted to practice by using a portable class library as a reference to bring the uppercase
/// method given to us into this program. I can use that class library by adding it to any solution 
/// in the future. My profressor told us to save the method so that's what I'm doing in a portable way.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// This is including the class library that contains the uppercase words method.
using DanielsClassLibrary;

namespace Assignment_6___LINQ {
    class Program {
        static void Main(string[] args) {
            // Standard list of strings
            List<string> items = new List<string>();
            // Standard WriteLine/ReadLine to gather input for the list
            Console.Write("Please enter first name: ");
            items.Add(Console.ReadLine());
            Console.Write("Please enter last name: ");
            items.Add(Console.ReadLine());
            Console.Write("Please enter street address: ");
            items.Add(Console.ReadLine());
            Console.Write("Please enter city: ");
            items.Add(Console.ReadLine());
            Console.Write("Please enter state: ");
            items.Add(Console.ReadLine());
            Console.Write("Please enter zip code: ");
            items.Add(Console.ReadLine());
            Console.WriteLine("");
            // Using LINQ to pass each item in a list to a method in a seperate class library referenced in the solution.
            var newList = from item in items
                          let upperCaseWord = UpperCaseFirstLetterOfWords.UppercaseWords(item)
                          select upperCaseWord;
            foreach (string item in newList) {
                Console.WriteLine(item);
            }
        }
        // The static method is a referenced class library in this solution.
    }
}
