using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam3 {
    class Program {
        static void Main(string[] args) {
            Student[] students = new Student[4];
            students[0] = new ElementarySchoolStudent("John", "Smith", "0001");
            students[1] = new MiddleSchoolStudent("Leroy", "Jenkins", "0002");
            students[2] = new HighSchoolStudent("Jerry", "Seinfeld", "0003");
            students[3] = new CollegeStudent("Jake", "Gillianhall", "0004");

            foreach (Student student in students) {
                Console.WriteLine(student.ToString());
            }
        }
    }
}
