/*
 *          Daniel Jackson - Exam 2 - Multiple Choice Project
 */


using System;

namespace MultipleChoiceProject {
    class Program {
        static void Main(string[] args) {
            // Keeping score and round count
            decimal score = 0;
            int count = 0;
            // Keeping entered answer, trying again, and percentage right
            string answer;
            string tryAgain;
            string percentage;
            // A boolean LCV
            bool runAgain = true;
            
            // Game start
            while (runAgain) {
                // Score reset to 0 after each round
                score = 0;
                // Round incrementer
                count++;

                // First question
                Console.WriteLine("");
                Console.WriteLine("Multiple Choice Questions, select only one answer in each question. (Note you have two attempts total, attempt {0})", count);
                Console.Write(@"  
                    1. Where is  the capital of the state of Florida?
                        A. Orlando
                        B. Tallahassee
                        C. Miami
                        D. Tampa
                                 
                    Answer:   ");

                answer = Console.ReadLine().ToUpper();

                switch (answer) {
                    case "A":
                        break;
                    case "B":
                        score++;
                        break;
                    case "C":
                        break;
                    default:
                        break;
                }

                // Second question
                Console.WriteLine("");
                Console.Write(@"  
                    2. Where is Walt Disney World Park located in Florida?
                        A. Orlando
                        B. Tallahassee
                        C. Miami
                        D. Tampa
                                 
                    Answer:   ");

                answer = Console.ReadLine().ToUpper();

                switch (answer) {
                    case "A":
                        score++;
                        break;
                    case "B":
                        break;
                    case "C":
                        break;
                    default:
                        break;
                }

                // Nested ?: (If Else) statements that determines what text score will be output
                percentage = score == 0 ? "Your score is 0" : score == 1 ? "Your score is: 50%" : "Your score is: 100%";
                Console.WriteLine(percentage);
                Console.WriteLine("");

                // Checking for score and count both being under 2
                // If score is 2 then round ends answers are 100%
                // If count is two then guess limit is reached and round ends
                if ((score < 2) && (count < 2)) {
                    Console.Write("Would you like to try one more time? (Y/N): ");
                    tryAgain = Console.ReadLine();
                    // If user enters uppercase or lowercase "N", sets LCV to false, round ends
                    if (tryAgain.ToUpper().Equals("N")) {
                        runAgain = false;
                    }
                    Console.WriteLine("");
                }
                // Sets LCV to false if score or count is 2 or more, round ends
                else {
                    runAgain = false;
                }
            }
        }
    }
}
