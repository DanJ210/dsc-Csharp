using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam3 {
    class HighSchoolStudent : Student {
        public HighSchoolStudent(string first, string last, string id)
            :base(first, last, id) {

        }

        public override string ImportantThings() {
            return "SAT Exam.";
        }

        public override string Math() {
            return "Basic Algebra.";
        }

        public override string ToString() {
            return $"My name is {firstName}, " +
                $"I am a high school student. " +
                $"I will take {ImportantThings()}, " +
                $"I learn {Math()}.";
        }
    }
}
