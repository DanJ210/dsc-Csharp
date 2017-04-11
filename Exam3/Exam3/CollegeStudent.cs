using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam3 {
    class CollegeStudent : Student {
        public CollegeStudent(string first, string last, string id)
            : base(first, last, id) {

        }

        public override string ImportantThings() {
            return "Major.";
        }

        public override string Math() {
            return "Advanced Algebra.";
        }

        public override string ToString() {
            return $"My name is {firstName}, " +
                $"I am a college student. " +
                $"I have a {ImportantThings()}, " +
                $"I learn {Math()}.\n";
        }
    }
}
