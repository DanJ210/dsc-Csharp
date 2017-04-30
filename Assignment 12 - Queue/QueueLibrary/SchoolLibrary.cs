using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Library that could hold many types of Queue's that I could return in different situations.
/* I'm using a neat <summary></summary> feature I learned that adds intellisense to these items.
 * You'll see the intellisense in the other Program.cs file when calling these methods. Hovering
 * over them shows the intellisense as well. Really neat.
 */

namespace QueueLibrary {
    /// <summary>
    /// Creates an object.
    /// </summary>
    public class QueueBook {
        
        /// <summary>
        /// Method that will return a new Queue object for me.
        /// No need for this except showing that things can be done this way.
        /// </summary>
        /// <returns>A new Queue object</returns>
        public Queue ReturnGeneratedQueue() {
            return new Queue();
        }
 
        /// <summary>
        /// Method to print items inside a Queue
        /// </summary>
        /// <param name="que">A Queue from a program</param>
        public void PeekQueue(Queue que) {
            if (que.Count != 0) {
                foreach (var item in que) {
                    Console.Write("{0} ", item);
                }
                Console.WriteLine("");
            }
        }
    }
}
