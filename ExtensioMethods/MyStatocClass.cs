using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensioMethods
{
    static class MyStatocClass
    {
        public static void fun3(this ExtensionRequire p)
        {
            Console.WriteLine("This is function 3");
        }

        public static bool isGreterThan(this int i, int value)
        {
            return i > value;
        }
    }
}
