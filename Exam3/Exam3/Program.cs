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
            students[2] = new HighSchoolStudent("first", "last", "id");
            students[3] = new CollegeStudent("first", "last", "id");

            for (int i=0; i<4; i++) {
                Console.WriteLine(students[i].ToString());
                Console.WriteLine("");
            }

            //foreach(Student student in students) {
            //    student.ToString();
            //}

            //"John", "Smith", "0001"
            //"Leroy", "Jenkins", "0002"
            //"Jerry", "Seinfeld", "0003"
            //"Jake", "Gillianhall", "0004"
        }
    }
}
