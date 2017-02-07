using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_1 {
    class Person {
        private string name;
        private int age;
        private int yearsToWork;
        public Person(int age) {
            retirementAge = age;
        }
        public int retirementAge { get; set; }
        public string personName {
            get {
                return name;
            }
            set {
                name = value;
            }
        }
        public int personAge {
            get {
                return age;
            }
            set {
                age = value;
            }
        }
        public int personYearsToWork {
            get {
                return yearsToWork;
            }
            set {
                yearsToWork = value;
            }
        }

        public int ytr() {
            return retirementAge - age;
        }

    }
}
