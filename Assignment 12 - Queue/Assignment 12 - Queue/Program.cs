using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QueueLibrary;

namespace Assignment_12___Queue {
    class Program {
        static void Main(string[] args) {
            Stack stack = new Stack();
            bool aBoolean = true;
            int aInteger = 3455;
            string aString = "testString";
            char aCharacter = 'A';
            
            QueueBook newQueueBook = new QueueBook();
            Queue newQueue = newQueueBook.ReturnGeneratedQueue();

            Console.WriteLine("I will add items to a Queue one by one.\n");

            newQueue.Enqueue(aBoolean);
            newQueueBook.PrintQueue(newQueue);
            newQueue.Enqueue(aInteger);
            newQueueBook.PrintQueue(newQueue);
            newQueue.Enqueue(aString);
            newQueueBook.PrintQueue(newQueue);
            newQueue.Enqueue(aCharacter);
            newQueueBook.PrintQueue(newQueue);

            Console.WriteLine("\nNow I will give an example of removing from the Queue, one by one.\n");

            newQueueBook.PrintQueue(newQueue);
            newQueue.Dequeue();
            newQueueBook.PrintQueue(newQueue);
            newQueue.Dequeue();
            newQueueBook.PrintQueue(newQueue);
            newQueue.Dequeue();
            newQueueBook.PrintQueue(newQueue);
            newQueue.Dequeue();
            //newQueueBook.PrintQueue(newQueue);

            Console.WriteLine("\nEnd of Queue Example.\n");
        }
    }
}
