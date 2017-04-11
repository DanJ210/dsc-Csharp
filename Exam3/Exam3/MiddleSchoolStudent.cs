using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam3 {
    class MiddleSchoolStudent : Student {
        public MiddleSchoolStudent(string first, string last, string id) 
            :base(first, last, id) {
            
        }

        public override string ImportantThings() {
            return "Summer Camp!";
        }

        public override string Math() {
            return "Basic Algrbra.";
        }

        public override string ToString() {
            return $"My name is {firstName}, " +
                $"I am a middle school student. " +
                $"I will have {ImportantThings()}, " +
                $"I will learn {Math()}.";
        }
    }
}
