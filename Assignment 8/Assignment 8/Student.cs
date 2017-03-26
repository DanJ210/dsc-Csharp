using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// I wanted to make this a seperate .DLL solutions and add it on like I have done before
// but I wasn't sure if that would be ok.
namespace Assignment_7 {
    class Student {
        public static int count { get; private set; }
        private static readonly Random rnd = new Random();
        public string firstName { private get; set; }
        public string lastName { private get; set; }
        public int studentId { private get; set; }

        public Student(string first, string last, int id) {
            ++count;
            this.lastName = last;
            this.firstName = first;
            this.studentId = id;
        }

        public Student(string first = "", string last = "") {
            ++count;
            this.lastName = last;
            this.firstName = first;
            this.studentId = rnd.Next(1000, 9999);
        }

        // Simple function that when calls, returns the entire output that I need for the assignment.
        // This allows me to keep all variables with private "get" functions.
        public string getStudent() {
            return "Student Name: " + this.firstName + " " + this.lastName + ", " + this.studentId;
        }
    }
}
