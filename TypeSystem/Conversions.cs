using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeSystem
{
    internal class Conversions
    {
        public static void method1()
        {
            int int1 = 123456789;
            long long1 = int1;
            Console.WriteLine($"int1={int1}\nlong1={long1}");

            double double1 = 123456789.0;
            int1 = (int)double1;
            Console.WriteLine($"double1={double1}\nint1={int1}");

            
        }
    }
}
