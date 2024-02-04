using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional.ClassInheritence
{
    internal class Class1
    {
        public void fun() {
            Console.WriteLine("Class 1 function");
        }
    }
    internal class Class2 : Class1
    {
        public new void fun()
        {
            Console.WriteLine("Class 2 function");
        }
    }
    internal class Class3: Class2
    {
        public new void fun()
        {
            Console.WriteLine("Class 3 function");
        }
    }
}
