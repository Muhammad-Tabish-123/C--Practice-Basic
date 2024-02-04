using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndCollection
{
    internal class QueueExample
    {
        Queue myQueue=new Queue();
        public void input(Object value) {
            myQueue.Enqueue(value);
        }
        public void remove() { 
            myQueue.Dequeue();
        }
        public void output() {
            Console.Write(myQueue.Peek());
        }
        public void removeAll()
        {
            myQueue.Clear();
        }
        public void containsValue(Object value)
        {
            Console.WriteLine("Value in QUEUE IS : "+myQueue.Contains(value));
        }
        public void countValues()
        {
            Console.WriteLine($"There are {myQueue.Count} values in queue");
        }
        public void showAll() { foreach (Object obj in myQueue) Console.Write(obj + " "); Console.WriteLine(); }

        public static void implementationExample()
        {
            QueueExample myQueueExample = new QueueExample();
            //myQueueExample.countValues();
            myQueueExample.input(20);
            myQueueExample.input("Alpha");
            myQueueExample.input(30);
            //myQueueExample.removeAll();
            myQueueExample.showAll();
            myQueueExample.remove();
            myQueueExample.showAll();
            myQueueExample.remove();
            myQueueExample.showAll();
            myQueueExample.remove();
            //myQueueExample.containsValue(20);
            //myQueueExample.containsValue("Alpha");
            //myQueueExample.containsValue(59);
            //myQueueExample.countValues();
        }
    }
}
