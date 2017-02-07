using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_1 {
    class Program {
        static void Main(string[] args) {
            Person worker = new Person(65);
            Console.Write("What is you name? ");

            worker.personName = Console.ReadLine();

            Console.Write("What is your age? ");

            worker.personAge = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine(worker.personName + ", you will work " 
                + worker.ytr() + " years before you retire.");

            Console.ReadLine();
        }
    }
}
