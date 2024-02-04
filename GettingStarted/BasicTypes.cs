using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStarted
{
     class BasicTypes
    {
        public static void BasicTpesMethod()
        {
            
            int a = 40;
            float b = 20;
            double c = 20.32;
            double d = 30.32f;
            bool e = true;
            bool f = false;
            var g = 0;
            var h = 1.0999;

            Console.WriteLine(a+" "+b+" "+c+" "+d+" " + e+" " + f+" " + g+" "+h);
            Console.WriteLine(a.GetType());
            Console.WriteLine(b.GetType());
            Console.WriteLine(c.GetType());
            Console.WriteLine(d.GetType());
            Console.WriteLine(e.GetType());
            Console.WriteLine(f.GetType());
            Console.WriteLine(g.GetType());
            Console.WriteLine(h.GetType());

            Console.WriteLine("New pat 2 types");
            long i = 392381908902820;
            Console.WriteLine(i+" " );
            Console.WriteLine(i.GetType());


        }
    }
}
