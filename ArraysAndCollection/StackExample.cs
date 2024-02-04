using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndCollection
{
    internal class StackExample
    {
       Stack myStack=new Stack();

        public  void AddToStack(Object value)
        {
            myStack.Push(value);
        }
        public  void RemoveFromStack()
        {
            myStack.Pop();

        }
        public  void ClearStack()
        {
            myStack.Clear();

        }
        public  void PeekFromStack()
        {
            Console.WriteLine(myStack.Peek());

        }
        public  void CountStack()
        {
            Console.WriteLine(myStack.Count);

        }
        public  void ClearValuesOfStack()
        {
            myStack.Clear();
        }
        public  void ConatinsStack(Object value)
        {
            Console.WriteLine(myStack.Contains(value));
        }
        public void ShowAllStack()
        {
            foreach (Object value in myStack) { Console.WriteLine(value); }
        }
        public static void implementationExample()
        {
            StackExample stackExampleObj = new StackExample();
            //stackExampleObj.PeekFromStack();
            //stackExampleObj.CountStack();
            stackExampleObj.AddToStack(10);
            stackExampleObj.AddToStack(true);
            stackExampleObj.AddToStack("A");
            //stackExampleObj.ShowAllStack();
            stackExampleObj.ConatinsStack(true);
            stackExampleObj.ConatinsStack("A");
            stackExampleObj.ConatinsStack(10);

            //stackExampleObj.CountStack();

            //stackExampleObj.PeekFromStack();
            //stackExampleObj.RemoveFromStack();
            //stackExampleObj.RemoveFromStack();
            //stackExampleObj.RemoveFromStack();
            //stackExampleObj.ClearStack();
            //stackExampleObj.CountStack();
            //stackExampleObj.ShowAllStack();

        }

    }
}
