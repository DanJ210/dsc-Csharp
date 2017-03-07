using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// I made a seperate solution that could be a portable class library which saves the uppercase
// method that my professor told me to save for use anywhere that I attach this library to.
// I can copy the project folder to the class library to anywhere and reference it to use it over again.
using DanielsClassLibrary;

namespace Assignment_6___LINQ {
    class Program {
        static void Main(string[] args) {
            List<string> items = new List<string>();

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

            var newList = from item in items
                          let upperCaseWord = DanielsClassLibrary.UpperCaseFirstLetterOfWords.UppercaseWords(item)
                          select upperCaseWord;
            foreach (string item in newList) {
                Console.WriteLine(item);
            }
        }
        // Static method to uppercase the first letter of a word.
        
    }
}
