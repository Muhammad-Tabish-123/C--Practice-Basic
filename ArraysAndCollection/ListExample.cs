using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ArraysAndCollection
{
    internal class ListExample
    {
        List<int> list=new List<int>();
        List<int> list2 = new List<int>();


        public ListExample()
        {
            list.Add(30);
            list.Add(20);
            list.Add(40);
            list.Add(10);

            list2.Add(333);
            list2.Add(444);
            list2.Add(222);
            list2.Add(111);
            list2.Add(999999);
            list2.Add(8888);
            list2.Add(37383);



            Console.WriteLine(list.Count);
            list.Sort();
            showAllMethd();
            list.Contains(30); 
            list.Remove(20);
            list.RemoveAt(2);
            showAllMethd();

            Console.WriteLine(list.Capacity);
            list.AddRange(list2);
            showAllMethd();
            list.RemoveAll(i=>i>500);
            showAllMethd();


        }



        public void showAllMethd()
        {
            foreach (int i in list) { Console.Write(i + " ");  }
            Console.WriteLine("\n----------------------");
        }
    }
}
