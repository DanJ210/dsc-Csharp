using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary {
    public class Student {
        public static int Count { get; set; }
        public static readonly Random rnd;

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int StudentId { get; private set; }

        public Student(string first, string last, int id) {
            this.FirstName = first;
            this.LastName = last;
            this.StudentId = id;
            Count++;
        }

        public Student(string first="", string last="") {
            this.FirstName = first;
            this.LastName = last;
            this.StudentId = rnd.Next(1000, 9999);
        }
    }
}
