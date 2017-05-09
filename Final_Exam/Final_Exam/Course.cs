using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Exam {
    class Course {
        // Private Data Members
        private string CID;
        private string CName;

        // Properties
        public string Id { get; set; }
        public string Name { get; set; }

        // Class Constructor
        public Course(string courseId, string courseName) {
            Id = courseId;
            Name = courseName;
        }
    }
}
