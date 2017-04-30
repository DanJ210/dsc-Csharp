using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QueueLibrary;

/* @author Daniel Jackson
 * @desc Assignment 12 - Queue
 * 
 * I made a seperate new project off of memory. I didn't want to copy the stack exactly
 * but this wasn't difficult to remember so it still looks like a copy, just in Queue form. */

namespace Assignment_12___Queue {
    class Program {
        static void Main(string[] args) {

            // Variables to add to the Queue
            bool aBoolean = true;
            int aInteger = 3455;
            string aString = "testString";
            char aCharacter = 'A';

            QueueBook newQueueBook = new QueueBook();
            Queue newQueue = newQueueBook.ReturnGeneratedQueue();
            
            // Adding to Queue and printing out each result.
            try {
                Console.WriteLine("I will add items to a Queue one by one.\n");

                newQueue.Enqueue(aBoolean);
                newQueueBook.PeekQueue(newQueue);
                newQueue.Enqueue(aInteger);
                newQueueBook.PeekQueue(newQueue);
                newQueue.Enqueue(aString);
                newQueueBook.PeekQueue(newQueue);
                newQueue.Enqueue(aCharacter);
                newQueueBook.PeekQueue(newQueue);

            } catch(Exception ex) {
                Console.WriteLine("Error creating Queue: {0}", ex.Message);
            }
            
            // Removing from Queue and printing out each result
            try {
                Console.WriteLine("\nNow I will give an example of removing from the Queue, one by one.\n");

                newQueueBook.PeekQueue(newQueue);
                newQueue.Dequeue();
                newQueueBook.PeekQueue(newQueue);
                newQueue.Dequeue();
                newQueueBook.PeekQueue(newQueue);
                newQueue.Dequeue();
                newQueueBook.PeekQueue(newQueue);
                newQueue.Dequeue();
            } catch (Exception ex) {
                Console.WriteLine("Error creating Queue: {0}", ex.Message);
            }

            // End of program message
            Console.WriteLine("\nEnd of Queue Example.\n");
        }
    }
}
