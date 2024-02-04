using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeSystem
{
    internal class StringBuilder
    {
        public static void Method1()
        {
            //Problem: Immmuteable strings
            //Solution: String builder
            System.Text.StringBuilder myStringBuilder = new System.Text.StringBuilder();
            myStringBuilder.Append("New string");
            Console.WriteLine(myStringBuilder);
            myStringBuilder.AppendLine("lINE#2");
            Console.WriteLine(myStringBuilder);
            myStringBuilder.AppendLine("lINE#3");
            Console.WriteLine(myStringBuilder);
            myStringBuilder.AppendLine("lINE#4");
            Console.WriteLine(myStringBuilder);
            myStringBuilder.AppendLine("lINE#5");
            Console.WriteLine(myStringBuilder);
            Console.WriteLine(myStringBuilder.ToString());
        }
    }
}
