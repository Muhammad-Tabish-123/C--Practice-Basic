using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndCollection
{
    internal class LinkedListExample
    {
        LinkedList<string> myLinked = new LinkedList<string>();

        public LinkedListExample()
        {
            myLinked.AddLast("Manager");
            myLinked.AddLast("Sales Manager");
            myLinked.AddLast("Accountant");
            myLinked.AddFirst("Sales Person");
            showAll();

            //LinkedListNode<string> ?NodeToFind = myLinked.Find("Accountant");
            LinkedListNode<string>? NodeToFind2 = myLinked.Find("Sales Manager");
            Console.WriteLine(NodeToFind2?.Next);
            Console.WriteLine(NodeToFind2?.Previous);
            var NextNode = NodeToFind2?.Next;
            var PreNode = NodeToFind2?.Previous;

            Console.WriteLine(NextNode?.Value);
            Console.WriteLine(PreNode?.Value);

            myLinked.AddBefore(NodeToFind2,"NeValueAdded1");
            myLinked.AddAfter(NodeToFind2, "NeValueAdded2");
            showAll();

            myLinked.RemoveFirst();
            myLinked.RemoveLast();
            myLinked.Remove(NodeToFind2);
            showAll();

        }

        void showAll()
        {
            Console.WriteLine("----ShowingValues-------");
            foreach (var val in myLinked) { Console.Write(val + " "); }
            Console.WriteLine("\n-----------");
        }
    }
}
