using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Library that could hold many types of Queue's that I could return in different situations

namespace QueueLibrary {
    public class QueueBook {
        public Queue ReturnGeneratedQueue() {
            return new Queue();
        }

        public void PrintQueue(Queue que) {
            if (que.Count != 0) {
                //Console.Write("The Queue is: ");
                foreach (var item in que) {
                    Console.Write("{0} ", item);
                }
                Console.WriteLine("");
            }
        }
    }
}
