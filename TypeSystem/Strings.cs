using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeSystem
{
    internal class Strings
    {
        public static void Method1()
        {
            //Working with strings
            string firstName = "Bethany";
            if (firstName.Contains("beth") || firstName.Contains("Beth"))
            {
                Console.WriteLine("its " + firstName);
            }


            //Generating file path
            string path1 = "C\\folder\\file.extension";
            Console.WriteLine(path1);
            string path2 = @"C\folder\file.extension";
            Console.WriteLine(path2);

            // String comparision new method
            Console.WriteLine(Environment.NewLine + "Striang comparision");
            Console.WriteLine(firstName.Equals("a"));
            Console.WriteLine(firstName.Equals("Bethany"));

        }
    }
}
