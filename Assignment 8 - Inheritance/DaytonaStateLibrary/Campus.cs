using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaytonaStateLibrary {
    class Campus : DSC {
        private string campusName;
        public string departments;

        public Campus(string cName) {
            this.campusName = cName;
        }

        public string CampusName() {
            return campusName;
        }

        public string Departments() {
            return "Computer Science Department," +
                "Emergency Care Department," +
                "Police Academy";
        }

        public override string ShowAddress() {
            return "1770 Williamson Blvd., Daytona Beach" +
                "Florida 32117";
        }

        public override string ToString() {
            return base.SchoolName + CampusName() +
                " is located at " + ShowAddress() +
                ", it has " + Departments();
        }
    }
}
