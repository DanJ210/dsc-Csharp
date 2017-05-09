using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Exam {
    class Program {
        static void Main(string[] args) {

            Course course1 = new Course("CTS1851", "Internet Web Foundation");
            Course course2 = new Course("CGS2820", "Web Programming");
            Course course3 = new Course("CGS2821", "Advanced Web Programming");
            Course course4 = new Course("COP2361", "C# Programming");

            Dictionary<string, Course> Courses = new Dictionary<string, Course>();

            Courses.Add(course1.Id, course1);
            Courses.Add(course2.Id, course2);
            Courses.Add(course3.Id, course3);
            Courses.Add(course4.Id, course4);

            foreach (KeyValuePair<string, Course> kvp in Courses) {
                Console.WriteLine("The key is {0}, Value is {1}", kvp.Key, kvp.Value.Name);
            }
        }
    }
}
