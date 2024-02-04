using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramFlow
{
    internal class ListExample
    {

        static List<string> task = new List<string>();

        public static void method1()
        {
            Console.WriteLine(task);
            Console.WriteLine("Total tasks: " + task.Count);
            task.Add("Line1");
            task.Add("Line2");
            Console.WriteLine("task : " + task[1]);
            Console.WriteLine("Total tasks: " + task.Count);

        }
        public static void ifElseExample(bool isCoffeeScoreLower)
        {
            if (isCoffeeScoreLower)
            {
                task.Add("Ïnvestigate recipie and ingrediants");
            }
            else
            {
                task.Add("No taske");
            }

            Console.WriteLine("task : " + task[task.Count-1]);

        }
    }
}
