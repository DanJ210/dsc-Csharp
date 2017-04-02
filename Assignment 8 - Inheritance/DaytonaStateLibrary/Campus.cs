using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaytonaStateLibrary {
    public class Campus : DSC {
        // Defining Members
        private string campusName;
        public string departments;
        // Simple consntructor to take in a campus name
        public Campus(string cName) {
            this.campusName = cName;
        }
        // Simple method to return the private campus name
        public string CampusName() {
            return campusName;
        }
        // Simple method to return 
        public string Departments() {
            return "Computer Science Department,\n" +
                "Emergency Care Department,\n" +
                "Police Academy\n";
        }
        // Method to ovveride the base class's ShowAddress()
        public override string ShowAddress() {
            return "1770 Williamson Blvd., Daytona Beach, " +
                "Florida 32117";
        }
        // Method to override the base class's ToString()
        // which is an override already of the base Object class
        public override string ToString() {
            return base.SchoolName + " " + CampusName() +
                "\nis located at " + ShowAddress() +
                "\nit has: " + Departments();
        }
    }
}
