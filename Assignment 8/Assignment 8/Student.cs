using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7 {
    class Student {
        public static int count { get; private set; }
        //public static Random rnd { get; private set; }
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

        public string studentName() {
            return this.firstName + " " + this.lastName + " " + this.studentId;
        }
    }
}
