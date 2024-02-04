using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndCollection
{
    public class ArrayListExample
    {

        ArrayList MyList = new ArrayList()
        {
            "Alpha",'á',10,true,10.99
        };

        public  void addToArrayList<T>(T item)
        {
            MyList.Add(item);
        }
        public void showFromArrayList()
        {
            foreach(object i in MyList) {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        public void showCapacityOfArrayList()
        {
            Console.WriteLine("Capacity is "+MyList.Capacity);
        }
        public void insertBetweenArrayList<T>(int index,T value)
        {
            MyList.Insert(index,value);
        }
        public  void removeByValFromArrayList<T>(T value)
        {
            MyList.Remove(value);
        }
        public void removeByIndexFromArrayList(int index)
        {
            MyList.RemoveAt(index);
        }
        public void showSigleItemFromArrayList(int index)
        {
            Console.WriteLine($"Item at index {index} is {MyList[index]}");
        }

        public static void implementationExample()
        {
            ArrayListExample arrayListExampleObj = new ArrayListExample();
            arrayListExampleObj.showSigleItemFromArrayList(0);
            arrayListExampleObj.showSigleItemFromArrayList(2);
            arrayListExampleObj.showCapacityOfArrayList();
            arrayListExampleObj.addToArrayList(20);
            arrayListExampleObj.addToArrayList("Beta");
            arrayListExampleObj.showFromArrayList();
            arrayListExampleObj.insertBetweenArrayList(0, "atIndex0");
            arrayListExampleObj.showFromArrayList();
            arrayListExampleObj.removeByValFromArrayList(true);
            arrayListExampleObj.removeByIndexFromArrayList(0);
            arrayListExampleObj.showFromArrayList();
        }
    }
    
}
