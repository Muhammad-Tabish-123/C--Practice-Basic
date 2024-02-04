// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
namespace ArraysAndCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------ArrayList--------------\n");
            ArrayListExample.implementationExample();

            Console.WriteLine("\n-----------------HashTable--------------\n");
            HashTableExample.implementationExample();
            

            Console.WriteLine("\n-----------------Stack--------------\n");
            StackExample.implementationExample();

            Console.WriteLine("\n-----------------Queue--------------\n");
            QueueExample.implementationExample() ;

            Console.WriteLine("\n-----------------List Example--------------\n");
            ListExample newListObj = new ListExample();

            Console.WriteLine("\n-----------------Dictionary Example--------------\n");
            DictionaryExample DEObj = new DictionaryExample();

            Console.WriteLine("\n-----------------Linked List--------------\n");
            LinkedListExample newLinkObj= new LinkedListExample();

            Console.WriteLine("\n-----------------Array Exaple--------------\n");
            ArraysExample MyArrayConstrutor=new ArraysExample();
            
        }
    }
}
