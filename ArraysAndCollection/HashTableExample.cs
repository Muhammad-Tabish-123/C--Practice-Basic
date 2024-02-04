using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndCollection
{
    internal class HashTableExample
    {
        Hashtable ht = new Hashtable()
        {
            { "Id", 1123},
            {"Name", "Adil" },
            {"Salary", 25000.00 },
        };

        public HashTableExample() {
            //ht.Add("Id", 1123);
            //ht.Add("Name", "Adil");
            //ht.Add("Salary", 25000.00);
            ht.Add("Designation", "Manager");
            ht.Add("IsMarried", false);
 
            //Console.WriteLine(ht["IsMarried"]);
            //Console.WriteLine(ht["Name"]);
            //Console.WriteLine(ht["Id"]);
        }
        public void ShowValueOf(Object index)
        {
            Console.WriteLine(ht[index]);
            //ht.Clear();
        }
        public void ShowAll()
        {
            Console.WriteLine("Values are ??");
            foreach (object obj in ht.Values)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }

        public void GetKeysAndValues() {
            Console.WriteLine("Keys are :");
            foreach(Object key in ht.Keys) { Console.Write(key + " "); }
            Console.WriteLine("\nValuess are :");
            foreach (Object value in ht.Values) { Console.Write(value + " "); }
        }
        public void RemoveValue(object index)
        {
            ht.Remove(index);
        }
        public void RemoveAll()
        {
            //Console.WriteLine(ht.Count);
            ht.Clear();
        }
        public void ConatinsKeyMethod(Object Key)
        {
            Console.WriteLine(ht.Contains(Key));
            Console.WriteLine(ht.ContainsKey(Key));
        }
        public void AccessHashCode()
        {
            Console.WriteLine(ht.GetHashCode());
        }
        public static void implementationExample()
        {
            HashTableExample htObj = new HashTableExample();
            //htObj.ShowValueOf("IsMarried");
            //htObj.ShowValueOf("Name");
            //htObj.ShowValueOf("Id");
            //htObj.GetKeysAndValues();

            //htObj.ShowAll();
            //htObj.RemoveValue("Id");
            //htObj.RemoveValue("Name");
            //htObj.RemoveValue("Salary");
            //htObj.ShowAll();
            //htObj.RemoveAll();
            //htObj.ShowAll();

            //htObj.ConatinsKeyMethod("Adil");
            //htObj.ConatinsKeyMethod(1123);
            //htObj.ConatinsKeyMethod("Salary");

            htObj.AccessHashCode();

        }
    }
}
