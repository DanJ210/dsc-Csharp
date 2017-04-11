using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam3 {
    class Student : IMathClass {
        public string firstName, lastName, studentID;
        public Student(string first, string last, string Id) {
            firstName = first;
            lastName = last;
            studentID = Id;
        }

        public virtual string ImportantThings() {
            return "";
        }
        
    }
}
