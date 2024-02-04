using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndCollection
{
    internal class DictionaryExample
    {
        Dictionary<int,string> myDict=new Dictionary<int, string>();

        public DictionaryExample() {

            myDict.Add(0,"Name1");
            myDict.Add(1, "Name2");
            myDict.Add(2, "Name3");
            myDict.Add(3, "Name4");
            ShowAll();

            Console.WriteLine("Count check "+myDict.Count());
            Console.WriteLine("Key check " + myDict.ContainsKey(0));
            Console.WriteLine("Key check " + myDict.ContainsKey(100));
            Console.WriteLine("Value check " + myDict.ContainsValue("SNDAKAD"));
            Console.WriteLine("Value check " + myDict.ContainsValue("Name1"));

            myDict.Clear();
            ShowAll();

            myDict.Add(0, "Name1");
            myDict.Add(1, "Name2");
            myDict.Add(2, "Name3");
            myDict.Add(3, "Name4");

            myDict.Remove(2);
            ShowAll();


        }
        void ShowAll()
        {
            Console.WriteLine("----ShowAll----");
            foreach (var i in myDict.Keys) { Console.Write($"myDict[{i}]=={myDict[i]}   "); }
            Console.WriteLine("\n--------");
        }
    }
}
