/* Daniel Jackson - Final Exam */

using System;
using System.Collections.Generic;

namespace Final_Exam {
    class Program {
        static void Main(string[] args) {

            // Creating Course Objects
            Course course1 = new Course("CTS1851", "Internet Web Foundation");
            Course course2 = new Course("CGS2820", "Web Programming");
            Course course3 = new Course("CGS2821", "Advanced Web Programming");
            Course course4 = new Course("COP2361", "C# Programming");

            // Instantiating Dictionary
            Dictionary<string, Course> Courses = new Dictionary<string, Course>();

            // Adding Courses to Dictionary
            Courses.Add(course1.Id, course1);
            Courses.Add(course2.Id, course2);
            Courses.Add(course3.Id, course3);
            Courses.Add(course4.Id, course4);

            // Printing out Key and Value.Name
            foreach (KeyValuePair<string, Course> kvp in Courses) {
                Console.WriteLine("The key is {0}, Value is {1}", kvp.Key, kvp.Value.Name);
            }
        }
    }
}
