using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaytonaStateLibrary {
    public class DSC {
        // Private members
        private string schoolName = "Daytona State College";
        // Property to get private member
        public string SchoolName {
            get {
                return schoolName;
            }
        }
        // Simple method that can be overriden
        public virtual string ShowAddress() {
            return "1200 W. International Speedway Blvd., " +
                "Daytona Beach, Florida 32117";
        }
    }
}
