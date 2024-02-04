using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensioMethods
{
    class TsetExtensionMethod
    {
        static void Main()
        {
            ExtensionRequire obj =new ExtensionRequire();
            obj.fun1();
            obj.fun2();
            obj.fun3();
            int i = 20;
            bool b=i.isGreterThan(10);
            Console.WriteLine("is greater than result is "+b);
            
        }
    }
}
