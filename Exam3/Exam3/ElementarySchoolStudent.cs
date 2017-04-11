using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam3 {
    class ElementarySchoolStudent : Student {
        public ElementarySchoolStudent(string first, string last, string id)
            : base (first, last, id) {
            
        }

        public override string ImportantThings() {
            return "Farm Field Trip";
        }

        public override string Math() {
            return "Basic Math";
        }

        public override string ToString() {
            return $"My name is {firstName}, " +
                $"I am a an Elementary school student. " +
                $"I will have an exciting {ImportantThings()}, " +
                $"I will learn {Math()}.";
        }
    }
}
