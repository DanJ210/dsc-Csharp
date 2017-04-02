using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7 {
    class Program {
        static void Main(string[] args) {
            List<Student> myList = new List<Student>();

            Student s1 = new Student();
            s1.firstName = "John";
            s1.lastName = "Smith";
            s1.studentId = 2560;
            myList.Add(s1);

            Student s2 = new Student("Peter");
            myList.Add(s2);

            Student s3 = new Student("Morgan", "Simmons");
            myList.Add(s3);

            Student s4 = new Student("James", "Walters");
            myList.Add(s4);

            Student s5 = new Student("Linda", "Scott", 1005);
            myList.Add(s5);

            Console.WriteLine();

            Console.WriteLine("Total students: {0}", Student.count);
            // Simple foreach loops that calla a function of each object in the list.
            // Each object has the function getStudent().
            foreach (var student in myList) {
                Console.WriteLine(student.getStudent());
            }
            
        }
    }
}
